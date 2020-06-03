using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserVehicleSection.Models;
using UserVehicleSection.Services;
using UserVehicleSection.ViewModels;

namespace UserVehicleSection.Controllers
{
    public class AutoPortController : Controller
    {

        private IUserServices _repo;

        public AutoPortController(IUserServices repository)
        {
            _repo = repository;
        }

        [HttpGet()]
        public IActionResult ShopPortfolio([FromRoute(Name = "id")] string shopID, [FromRoute(Name = "status")] string shopStatus)
        {


            var ShopReqVeh = _repo.GetVehReqs.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(a => a.ServiceReqDb).Include(sp => sp.Vehicle).Include(u => u.Vehicle.User);

            var test = _repo.GetVehReqs.Include(a => a.ServiceReqDb).Include(sp => sp.ServicedHistDb)
                .Include(sp => sp.Vehicle).ThenInclude(s => s.User).Where(vh => vh.UserId.Equals(int.Parse(shopID)));

            var servicedHistDb = _repo.GetServicedHists;

            var actuall = _repo.GetVehReqs.Include(a => a.ServiceReqDb).Include(sp => sp.ServicedHistDb)
                .Include(sp => sp.Vehicle).ThenInclude(s => s.User).Where(vh => vh.UserId.Equals(int.Parse(shopID)));

            string returnString = String.Empty;

            foreach (var vehRequest in actuall)
            {
                if (vehRequest.ServicedHistDb.Count != 0)
                {
                    actuall = actuall.Where(sp => sp != vehRequest);
                }
            }
            
            var shop_user = new ShopListView
            {
                User = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(s => s.Image).FirstOrDefault(),
                ShopTeches = _repo.GetShopTeches.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(a => a.AssignedTechDb).ThenInclude(s => s.Service),
                ShopServices = _repo.GetShopServices.Where(s => s.UserId.Equals(int.Parse(shopID))),
                ShopReqVehDbs = actuall
            };
            return View(shop_user);
        }

        // Create New Technician
        public IActionResult ShopTech()
        {
            return View(new TechnicianModel
            {
                ShopServices = _repo.GetShopServices.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"]))),
                UserCookie = Request.Cookies["UserID"]

            });
        }

        [HttpPost]
        public async Task<IActionResult> ShopTech(TechnicianModel technicianModel)
        {
            if (ModelState.IsValid)
            {
                ShopTechDb techDb = new ShopTechDb
                {
                    UserId = int.Parse(Request.Cookies["UserID"]),
                    TechnicianName = technicianModel.TechnicianName,
                    TechnicianDescription = technicianModel.TechnicianDescription
                };

                bool result = await _repo.CreateShopTeches(techDb);

                if (result)
                {
                    var service = _repo.GetShopServices.Where(name => name.ServiceName.Equals(technicianModel.AssignedService)).FirstOrDefault();
                    AssignedTechDb assignedTech = new AssignedTechDb
                    {
                        TechnicianId = techDb.TechnicianId,
                        ServiceId = service.ServiceId
                    };

                    bool result1 = await _repo.CreateAssignedTech(assignedTech);

                    if (result1)
                    {
                        ViewBag.TechSuccess = "Shop Tech Added Added";
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Couldn't Add Shop Services. Try Again With Cookies Enabled");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Couldn't Add Shop Services. Try Again With Cookies Enabled");
                }
            }

            return View(new TechnicianModel
            {
                ShopServices = _repo.GetShopServices.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"])))
            });
        }

        //Assign Technician To Service
        public IActionResult AssignShopTech()
        {
            return View(new TechnicianModel
            {
                ShopServices = _repo.GetShopServices.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"]))),
                TechDbs = _repo.GetShopTeches.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"]))),
                UserCookie = Request.Cookies["UserID"]
            });
        }

        [HttpPost]
        public async Task<IActionResult> AssignShopTech(TechnicianModel model)
        {

            AssignedTechDb assignTech = new AssignedTechDb
            {
                TechnicianId = _repo.GetShopTeches.Where(name => name.TechnicianName.Equals(model.TechName)).FirstOrDefault().TechnicianId,
                ServiceId = _repo.GetShopServices.Where(name => name.ServiceName.Equals(model.AssignedService)).FirstOrDefault().ServiceId
            };


            bool result = await _repo.CreateAssignedTech(assignTech);

            if (result)
            {
                ViewBag.AssignedTechSucess = "Services Added to Technician";
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Couldn't Add Shop Services. Try Again With Cookies Enabled");
            }

            return View(new TechnicianModel
            {
                ShopServices = _repo.GetShopServices.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"]))),
                TechDbs = _repo.GetShopTeches.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"]))),
                UserCookie = Request.Cookies["UserID"]
            });
        }

        //Create Shop Services

        [HttpGet()]
        public IActionResult ShopServices([FromQuery(Name = "shopID")] string shopID)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ShopServices(ServicesModel servicesModel)
        {
            if (ModelState.IsValid)
            {
                ShopServicesDb services = new ShopServicesDb
                {
                    ServiceName = servicesModel.ServiceName,
                    UserId = int.Parse(Request.Cookies["UserID"]),
                    ServiceCost = servicesModel.ServiceCost,
                    ServiceDescription = servicesModel.ServiceDescription,

                };

                bool result = await _repo.CreateShopServices(services);

                if (result)
                {
                    ViewBag.ServiceSuccess = "Services Added";

                    //  return RedirectToAction("ShopServices", "Account");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Couldn't Add Shop Services. Try Again With Cookies Enabled");
                }
            }
            return View(servicesModel);
        }


        //Send Message To User
        [HttpPost]
        public async Task<IActionResult> Message(MessageModel message, [FromQuery(Name = "shopID")] string shopID, [FromQuery(Name = "vehReqID")] string vehReqID)
        {
            if (ModelState.IsValid)
            {
                MessageDb messageDb = new MessageDb
                {
                    VehReqId = int.Parse(vehReqID),
                    UserId = int.Parse(shopID),
                    Message = message.TextMessage,
                    MessageDate = message.DateMessage
                };

                bool result = await _repo.CreateMessage(messageDb);

                if (result)
                {
                    ViewBag.MessageSent = "Message Have been Sent";
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Couldn't Add Shop Services. Try Again With Cookies Enabled");
                }
            }

            return RedirectToAction("ShopPortfolio", "AutoPort", new { id = shopID, status = true });
        }


    }
}
