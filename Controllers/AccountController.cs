using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UserVehicleSection.Models;
using UserVehicleSection.Services;
using UserVehicleSection.ViewModels;

namespace UserVehicleSection.Controllers
{
    public class AccountController : Controller
    {
        /*
         * Delete Message Table record on User Side, 
         * Delete VehReq and SericeReq Table on Shop Side when,Regardless of Action
         */
        private UserManager<UserDb> userManager;
        private SignInManager<UserDb> signInManager;

        private IUserServices _repo;

        public AccountController(UserManager<UserDb> userMgr, SignInManager<UserDb> signInMgr, IUserServices repository)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            _repo = repository;
        }

        public IActionResult ShopTech()
        {
            return View(new TechnicianModel
            {
                ShopServices = _repo.GetShopServices.Where(s => s.UserId.Equals(int.Parse(Request.Cookies["UserID"]))),

            });
        }

        [HttpGet()]
        public async Task<IActionResult> Serviced([FromQuery(Name = "vehID")] string vehID, [FromQuery(Name = "shopID")] string shopID,
            [FromQuery(Name = "serCost")] string totalCost, [FromQuery(Name = "acceptance")] string condition, [FromQuery(Name = "shopPortfolio")] string redirect)
        {
            ServicedHistDb servicedHist = new ServicedHistDb
            {
                VehReqId = int.Parse(vehID),
                Cost = decimal.Parse(totalCost),
                Serviced = Boolean.Parse(condition),
                UserId = int.Parse(shopID)
            };

            bool result = await _repo.CreateServiceHist(servicedHist);

            if(result)
            {

                //var ServiceReqDb = _repo.GetServiceReqs.Where(a => a.VehReqId.Equals(int.Parse(vehID)));

                //var message = _repo.GetMessages.Where(a => a.VehReqId.Equals(int.Parse(vehID)));

                //var vehRequest = _repo.GetVehReqs.Where
                //if(Boolean.Parse(condition).Equals(true))

                //bool result1 = await _repo.de

                var messageObject = _repo.GetMessages.Where(a => a.VehReqId.Equals(int.Parse(vehID))).FirstOrDefault();

                if(messageObject != null)
                {
                    bool result1 = await _repo.DelMessageObject(messageObject);

                    if(result1)
                    {
                        ViewBag.Serviced = "Message Deleted";
                    }
                }

                //ViewBag.Serviced = "Car Serviced Now in History Section";                
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Couldn't Add Shop Services. Try Again With Cookies Enabled");
            }

            //string isShop = Request.Cookies["IsShop"];
            //string userID = Request.Cookies["UserID"];

            string portFolio = "UserPortfolio";
            
            if(Boolean.Parse(redirect))
            {
                portFolio = "ShopPortfolio";
                //return RedirectToAction("ShopPortfolio", "Account", new { id = shopID, status = true });
            }
            return RedirectToAction(portFolio, "Account", new { id = Request.Cookies["UserID"], status = Request.Cookies["IsShop"] });
           
        }
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
            //MessageDb messageDb = new MessageDb
            //{
            //    VehReqId = message.VehReqID,
            //    UserId = message.UserID,
            //    Message = message.TextMessage,
            //    MessageDate = message.DateMessage
            //};

            //return Content($"{message.TextMessage}\t {message.DateMessage} \t{shopID} \t {vehReqID}");

            return RedirectToAction("ShopPortfolio", "Account", new { id = shopID, status = true });
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

        [HttpGet()]
        public IActionResult ShopServices([FromQuery(Name = "shopID")] string shopID)
        {
            return View();
            //return Content($"Here is your Fucking: {shopID}");
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


        [HttpGet()]
        public IActionResult ShopPortfolio([FromRoute(Name = "id")] string shopID, [FromRoute(Name = "status")] string shopStatus)
        {
            //Get ShopID by Cookies
            //Can Include AssignedTech, ShopTech and ShopServices

            //var user = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(s => s.Image).FirstOrDefault();

            //var shopTeches = _repo.GetShopTeches.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(a => a.AssignedTechDb);

            //var shopServices = _repo.GetShopServices.Where(s => s.UserId.Equals(int.Parse(shopID)));

            //var shopReqVehDbs = _repo.GetVehReqs.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(a => a.ServiceReqDb);

            //var Tech_Assign = _repo.Get

            //var ShopReqVeh = _repo.GetVehReqs.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(a => a.ServiceReqDb).Include(sp => sp.Vehicle).Include(u => u.Vehicle.User);

            //var section = new MessageDb
            //{
            //    UserId = ShopReqVeh.
            //}

            //-------------> Re-Work ServicedHistoryDb and VehReqDb similar to UseDb and UserImgDb

            var ShopReqVeh = _repo.GetVehReqs.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(a => a.ServiceReqDb).Include(sp => sp.Vehicle).Include(u => u.Vehicle.User);

            var serviceHist = _repo.GetServicedHists.Where(s => s.UserId.Equals(int.Parse(shopID)));

            var test = _repo.GetVehReqs.Include(a => a.ServiceReqDb).Include(sp => sp.Vehicle).ThenInclude(s => s.User).Where(vh => vh.UserId.Equals(int.Parse(shopID)));

            //foreach (var item in test)
            //{
            //    foreach(var item1 in serviceHist)
            //    {
            //        if(item.VehReqId.Equals(item1.VehReqId))
            //        {
            //            test.ToList().Remove(item);
            //        }
            //    }
            //}


            var shop_user = new ShopListView
            {
                User = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(s => s.Image).FirstOrDefault(),
                ShopTeches = _repo.GetShopTeches.Where(s => s.UserId.Equals(int.Parse(shopID))).Include(a => a.AssignedTechDb),
                ShopServices = _repo.GetShopServices.Where(s => s.UserId.Equals(int.Parse(shopID))),
                ShopReqVehDbs = test
                //ShopReqVehDbs = _repo.GetVehReqs.Where(s=> s.UserId.Equals(int.Parse(shopID))).Include(a => a.ServiceReqDb).Include(sp => sp.Vehicle).Include(u => u.Vehicle.User),
                //ShopserviceReqs = _repo.GetServiceReqs.Include(a => a.)

                //ShopserviceReqs = _repo.GetServiceReqs
            };
            return View(shop_user);
        }

        [HttpGet()]
        public IActionResult VehReq([FromQuery(Name = "vehID")] string vehicleID)
        {
            var shops = new VehicleReqModel
            {
                Shoppers = _repo.GetUserDbs.Where(s => s.IsShop.Equals(true)),
                VehicleID = int.Parse(vehicleID)
                // AssignedTeches = _repo.GetAssignedTechDbs.Include(ap => ap.Technician).Include(se => se.Service)
                // AssignedTeches = _repo.GetAssignedTechDbs.Include(ap => ap.Service).Include(ad => ad.Service.User).Where(a => a.Service.User.IsShop.Equals(true)),
                // AssignedTeches = _repo.GetAssignedTechDbs.Include(a => a.Service.User).Where(a => a.Service.User.IsShop.Equals(true)).Include(ap => ap.Service).Include(al => al.Technician)
            };

            return View(shops);
            //return Content($"Here is your Vehicle: {int.Parse(vehicleID)}");
        }
        [HttpPost]
        public IActionResult VehReqs([FromQuery(Name = "shopID")] string shopsID, [FromQuery(Name = "vehID")] string vehicleID)
        {
            var checkList = new List<CheckBoxItem>();
            var Teches = _repo.GetAssignedTechDbs.Include(se => se.Service).Where(id => id.Service.UserId.Equals(int.Parse(shopsID))).Include(st => st.Technician).Where(ids => ids.Technician.UserId.Equals(int.Parse(shopsID)));
            foreach (var services in Teches)
            {
                checkList.Add(new CheckBoxItem()
                {
                    Id = services.AssignId,
                    Title = services.Service.ServiceName,
                    IsChecked = false
                });
            }

            var user = new VehicleReqModel
            {
                GetUser = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(shopsID))).FirstOrDefault(),
                CheckBoxItems = checkList,
                AssignedTeches = Teches,
                VehicleID = int.Parse(vehicleID),
                UserID = int.Parse(shopsID)
                // AssignedTeches = _repo.GetAssignedTechDbs
                // AssignedTeches = _repo.GetAssignedTechDbs.Include(se => se.Service).Where(id => id.Service.UserId.Equals(int.Parse(shopsID))).Include(st => st.Technician).Where(ids => ids.Technician.UserId.Equals(int.Parse(shopsID)))
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
                // AssignedTeches = _repo.GetAssignedTechDbs
                // AssignedTeches = _repo.GetAssignedTechDbs.Include(se => se.Service).Where(id => id.Service.UserId.Equals(int.Parse(shopsID))).Include(st => st.Technician).Where(ids => ids.Technician.UserId.Equals(int.Parse(shopsID)))
            };
            return View("VehReqs", user);

            //string conct = String.Empty;
            //foreach (var ite in Blanks)
            //{
            //    conct += ite;
            //}
            //return Content($"{conct} plus {model.VehReqName} PLUS {vehicleID}");

            // return View("Index", Blanks);
        }

        //[HttpPost]
        //public async Task<IActionResult> VehReqs(VehicleReqModel reqModel)
        //{
        //    return Content($"{reqModel.AssignedTeches.FirstOrDefault().AssignId}");
        //}

        public IActionResult Vehicle([FromQuery(Name = "email")]string smodel)
        {
            return View(new ListView
            {
                Results = _repo.GetVehichleMakesAsync().Result.Take(20)
            });
        }

        [HttpGet()]
        public IActionResult UserPortfolio([FromRoute(Name = "id")]string userID)
        {
            //Have 
            List<int> vale = new List<int>() { 1, 2, 3, 4 };

            var message = _repo.GetMessages.Include(ap => ap.VehReq)
                .Include(ap => ap.VehReq.ServicedHistDb).Include(ap => ap.VehReq.User).Include(sp => sp.VehReq.ServiceReqDb).ThenInclude(sa => sa.Assign.Service)
                .Include(ap => ap.VehReq.Vehicle).ThenInclude(sp => sp.User)
                .Where(a => a.VehReq.Vehicle.User.UserId.Equals(int.Parse(userID)));

            var testing = _repo.GetUserVehs.Where(s => s.UserId.Equals(int.Parse(userID)))
                .Include(sp => sp.VehReqDb).ThenInclude(p => p.MessageDb);


            var vehicles = _repo.GetUserVehs.Where(s => s.UserId.Equals(int.Parse(userID)));

            var userVehReq = _repo.GetUserVehs.Where(s => s.UserId.Equals(int.Parse(userID)))
                .Include(sp => sp.VehReqDb).ThenInclude(ap => ap.ServicedHistDb);

            var VehReqSection = _repo.GetVehReqs.Include(sp => sp.User).Include(p => p.MessageDb).Include(o => o.ServicedHistDb)
                .Include(sp => sp.Vehicle).ThenInclude(sp => sp.User).Where(a => a.Vehicle.UserId.Equals(int.Parse(userID)));


            var vehServicedHist = _repo.GetServicedHists.Include(sp => sp.VehReq).ThenInclude(uv => uv.Vehicle).Where(ap => ap.VehReq.Vehicle.UserId.Equals(int.Parse(userID)));
           //  --------------- >>> var servicedHistDb = _repo.GetServicedHists.Include(ap => ap.VehReq).ThenInclude(sp => sp.Vehicle).Where(sp => sp.VehReq.Vehicle.UserId.Equals(int.Parse(userID)));


            //var testringReq = _repo.GetVehReqs.Include(sh => sh.ServicedHistDb).Include(op => op.MessageDb)
            //    .Where(sa => sa.veh)
            //var Message = _repo.GetMessages
            

            //var history = _repo.GetServicedHists.Where(sp => sp.VehReqId.Equals(userVehReq.))
           // var testing = _repo.GetVehReqs.Include()
           //


            //var testing = _repo.GetVehReqs.Include(s => s.MessageDb).ThenInclude(sp => sp.)


            //var messsage = _repo.GetMessages.Where(u => u.VehReqId.Equals(userVehReq.))
            //var userVehReq = _repo.GetVehReqs.Where(s => s.VehicleId.Equals(vehicles.Select(s => s.VehicleId)));

            var user = new UserListVIew
            {
                User = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(userID))).Include(s => s.Image).FirstOrDefault(),
               // UserVehDbs = _repo.GetUserVehs.Where(s => s.UserId.Equals(int.Parse(userID))),
                UserVehDbs = userVehReq,
                UserReqDbs = VehReqSection,
                MessageDbs = message,
                ServicedHistDbs = vehServicedHist
            };

            return View(user);
        }

        //[HttpGet()]
        //public IActionResult Actions([FromRoute(Name = "id")]string userID)
        //{
        //    return Content($"dfs{int.Parse(userID)}");
        //}


        public IActionResult _Model()
        {
            return View(new ListView
            {
                VehModel = HttpUtility.UrlDecode(Request.Cookies["Makess"])
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

                Response.Cookies.Append("Veh1", vehicleModel.VehMake);
                Response.Cookies.Append("Veh2", vehicleModel.VehModel);
                Response.Cookies.Append("Veh3", vehicleModel.VehYear);
                Response.Cookies.Append("Veh4", vehicleModel.VehMileage.ToString());
                Response.Cookies.Append("Veh5", vehicleModel.VehVinNum);


                bool result = await _repo.CreateUserVeh(userVeh);

                if (result)
                {
                    ViewBag.VehSuccess = "Vehicle Registered ";

                    //return View("Vehicle");
                    //return RedirectToAction("Vehicle", "Account");
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
            //return View("Vehicle");
        }


        //[HttpPost]
        //public ActionResult GetModels(ListView listView)
        //{
        //    return Content($"Make{listView.VehMake}");

        //    //return View("Vehicle", new { smodel = email });
        //}


        //[HttpPost]
        //public IActionResult GetModels(string com)
        //{
        //    return View("Vehicle", new { email = com });
        //}

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegiserModel model)
        {
            if (ModelState.IsValid)
            {

                UserImgDb userImg = new UserImgDb();
                using (var memoryStream = new MemoryStream())
                {
                    await model.ImgPic.CopyToAsync(memoryStream);

                    userImg.UserImg = memoryStream.ToArray();
                }

                bool result = await _repo.CreateUserImgAsync(userImg);

                if (result)
                {
                    UserDb user = new UserDb
                    {
                        UserName = model.AccountName,
                        UserEmail = model.AccountEmail,
                        UserAddress = model.AccountAddress,
                        UserCity = model.AccountCity,
                        UserCountry = model.AccountCountry,
                        UserDescription = model.AccountDescription,
                        ImageId = userImg.ImageId
                    };

                    if (model.IsShop)
                    {
                        user.IsShop = true;
                    }

                    var identityResult = await userManager.CreateAsync(user, model.AccountPassword);

                    if (identityResult.Succeeded)
                    {
                        ViewBag.Set = "You are all Set to Register";
                        // return Request.
                        // return RedirectToAction("Index", "Account");
                    }
                    else
                    {
                        //string errorList = String.Empty;

                        foreach (IdentityError error in identityResult.Errors)
                        {
                            //errorList += error.Description;
                            ModelState.AddModelError("", error.Description);
                        }

                        //return Content($"Error in the Following: {errorList}");
                    }

                }


            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> LogIn(SignInModel details) // This was the LogInModel
        {
            if (ModelState.IsValid)
            {

                UserDb user = await userManager.FindByNameAsync(details.UserName);

                if (user != null)
                {
                    await signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, details.Password, false, false);

                    if (result.Succeeded)
                    {
                        Response.Cookies.Append("UserID", user.UserId.ToString());
                        Response.Cookies.Append("UserName", user.UserName);
                        Response.Cookies.Append("UserImage", user.ImageId.ToString());
                        Response.Cookies.Append("IsShop", user.IsShop.ToString());

                        // return RedirectToAction("Vehicle", "Account",new {id = user.UserId });
                        if (user.IsShop == true)
                        {
                            return RedirectToAction("ShopPortfolio", "Account", new { id = user.UserId, status = user.IsShop });
                        }
                        else
                        {
                            return RedirectToAction("UserPortfolio", "Account", new { id = user.UserId, status = user.IsShop });
                        }

                    }
                }
                ModelState.AddModelError(nameof(SignInModel.UserName), "Invalid user or password");

            }
            return View(details);


        }


    }
}