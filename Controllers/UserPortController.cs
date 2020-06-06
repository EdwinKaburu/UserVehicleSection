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
    public class UserPortController : Controller
    {
        private IUserServices _repo;

        public UserPortController(IUserServices repository)
        {
            _repo = repository;
        }

        //User Portfolio/Potential Customer
        [HttpGet()]
        public IActionResult UserPortfolio([FromRoute(Name = "id")] string userID)
        {
            /*
             * Change to Use Cookies
             * 
             * Get Data based on LoginIn Information
             * 
             * int.Parse(Request.Cookies["UserID"])
             */

            var getuser = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"]))).Include(s => s.Image).FirstOrDefault();

            var userVehReq = _repo.GetUserVehs.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"])))
                .Include(sp => sp.VehReqDb).ThenInclude(ap => ap.ServicedHistDb);

            var VehReqSection = _repo.GetVehReqs.Include(sp => sp.User).Include(p => p.MessageDb).Include(o => o.ServicedHistDb)
               .Include(sp => sp.Vehicle).ThenInclude(sp => sp.User).Where(a => a.Vehicle.UserId.Equals(int.Parse(Request.Cookies["UserID"])));


            var vehServicedHist = _repo.GetServicedHists.Include(sp => sp.VehReq).ThenInclude(uv => uv.Vehicle)
                .Where(ap => ap.VehReq.Vehicle.UserId.Equals(int.Parse(Request.Cookies["UserID"])));

            var message = _repo.GetMessages.Include(ap => ap.VehReq)
                .Include(ap => ap.VehReq.ServicedHistDb).Include(ap => ap.VehReq.User).Include(sp => sp.VehReq.ServiceReqDb).ThenInclude(sa => sa.Assign.Service)
                .Include(ap => ap.VehReq.Vehicle).ThenInclude(sp => sp.User)
                .Where(a => a.VehReq.Vehicle.User.UserId.Equals(int.Parse(Request.Cookies["UserID"])));


            var user = new UserListVIew
            {
                User = getuser,
                UserVehDbs = userVehReq,
                UserReqDbs = VehReqSection,
                MessageDbs = message,
                ServicedHistDbs = vehServicedHist
            };

            return View(user);
        }

        [HttpGet()]
        public IActionResult GetShoppersReq([FromQuery(Name = "vehID")] string vehicleID)
        {
            //Get AutoShops

            var shops = new VehicleReqModel
            {
                Shoppers = _repo.GetUserDbs.Where(s => s.IsShop.Equals(true)),
                VehicleID = int.Parse(vehicleID)
            };

            return View(shops);
        }

        [HttpPost]
        public IActionResult VehReqs([FromQuery(Name = "shopID")] string shopsID, [FromQuery(Name = "vehID")] string vehicleID)
        {
            var checkList = new List<CheckBoxItem>();
            var Teches = _repo.GetAssignedTechDbs.Include(se => se.Service).Where(id => id.Service.UserId.Equals(int.Parse(shopsID)))
                .Include(st => st.Technician).Where(ids => ids.Technician.UserId.Equals(int.Parse(shopsID)));
            foreach (var services in Teches)
            {
                checkList.Add(new CheckBoxItem()
                {
                    Id = services.AssignId,
                    Title = services.Service.ServiceName,
                    IsChecked = false
                });
            }

            var shopServices = _repo.GetShopServices.Include(s => s.AssignedTechDb).ThenInclude(sp => sp.Technician).Where(ids => ids.UserId.Equals(int.Parse(shopsID)));

            var shop_Services = _repo.GetShopServices.Include(sp => sp.AssignedTechDb).ThenInclude(ap => ap.Technician).Where(ids => ids.UserId.Equals(int.Parse(shopsID)));

            var user = new VehicleReqModel
            {
                GetUser = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(shopsID))).FirstOrDefault(),
                ShopServices = shop_Services,
                CheckBoxItems = checkList,
                AssignedTeches = Teches,
                VehicleID = int.Parse(vehicleID),
                UserID = int.Parse(shopsID)
            };
            return View(user);
        }


        [HttpPost]
        public async Task<IActionResult> CheckBoxTester(VehicleReqModel model, string[] Blanks, [FromQuery(Name = "vehID")] string vehicleID, [FromQuery(Name = "shopID")] string shopsID)
        {
            if (ModelState.IsValid)
            {
                VehReqDb vehReq = new VehReqDb
                {
                    VehicleId = int.Parse(vehicleID),
                    VehReqName = model.VehReqName,
                    VehReqDate = model.VehdateTime,
                    UserId = int.Parse(shopsID),
                    VehReqMessage = model.VehMessage
                };

                bool result = await _repo.CreateVehReq(vehReq);

                if (result)
                {

                    string servicereqAdded = String.Empty;

                    bool reload_error = false;

                    foreach (var ite in Blanks)
                    {
                        ServiceReqDb serviceReq = new ServiceReqDb
                        {
                            VehReqId = vehReq.VehReqId,
                            AssignId = int.Parse(ite)
                        };

                        reload_error = await _repo.CreateServiceReq(serviceReq);

                        if (reload_error)
                        {
                            servicereqAdded += $"{ite}\t";
                        }

                    }

                    //reload = true;

                    if (reload_error)
                    {
                        ViewBag.RequestSent = "Request Sent" + servicereqAdded;
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Couldn't Add Shop Services. Try Again With Cookies Enabled");
                    }

                }
            }

            var user = new VehicleReqModel
            {
                GetUser = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(shopsID))).FirstOrDefault(),
                AssignedTeches = _repo.GetAssignedTechDbs.Include(se => se.Service).Where(id => id.Service.UserId.Equals(int.Parse(shopsID))).Include(st => st.Technician).Where(ids => ids.Technician.UserId.Equals(int.Parse(shopsID))),
                VehicleID = int.Parse(vehicleID),
                UserID = int.Parse(shopsID)
            };


            return View("VehReqs", user);
        }



        [HttpGet()]
        public IActionResult Vehicle([FromQuery(Name = "UserID")] string UserID)
        {
            return View(new ListView
            {
                Results = _repo.GetVehichleMakesAsync().Result,
                redirectID = Request.Cookies["UserID"]
                //redirectID = UserID
            });
        }

        [HttpPost]
        public async Task<IActionResult> Vehicle(ListView vehicleModel)
        {

            if (ModelState.IsValid)
            {
                UserVehDb userVeh = new UserVehDb
                {
                    UserId = int.Parse(Request.Cookies["UserID"]),
                    VehicleMake = vehicleModel.VehMake,
                    VehicleModel = vehicleModel.VehModel,
                    VehicleYear = vehicleModel.VehYear,
                    VehicleMileage = vehicleModel.VehMileage,
                    VehicleVinNum = vehicleModel.VehVinNum
                };

                //Response.Cookies.Append("Veh1", vehicleModel.VehMake);
                //Response.Cookies.Append("Veh2", vehicleModel.VehModel);
                //Response.Cookies.Append("Veh3", vehicleModel.VehYear);
                //Response.Cookies.Append("Veh4", vehicleModel.VehMileage.ToString());
                //Response.Cookies.Append("Veh5", vehicleModel.VehVinNum);


                bool result = await _repo.CreateUserVeh(userVeh);

                if (result)
                {
                    ViewBag.VehSuccess = "Vehicle Registered ";
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Couldn't Register Vehicle. Try Again With Cookies Enabled");
                }

            }
            return View(new ListView
            {
                Results = _repo.GetVehichleMakesAsync().Result.Take(20)
            });
        }

    }
}
