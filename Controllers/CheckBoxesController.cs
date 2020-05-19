using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserVehicleSection.Models;
using UserVehicleSection.Services;
using UserVehicleSection.ViewModels;

namespace UserVehicleSection.Controllers
{
    public class CheckBoxesController : Controller
    {

        private UserManager<UserDb> userManager;
        private SignInManager<UserDb> signInManager;

        private IUserServices _repo;

        public CheckBoxesController(UserManager<UserDb> userMgr, SignInManager<UserDb> signInMgr, IUserServices repository)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            _repo = repository;
        }


        [HttpGet()]
        public IActionResult VehReq([FromQuery(Name = "vehID")] string vehicleID)
        {
            var shops = new VehicleReqModel
            {
               // AssignedTeches =  _repo.GetAssignedTechDbs.Where(s => s.)
               // Shoppers = _repo.GetUserDbs.Where(s => s.IsShop.Equals(true)).Include(se => se.ShopServicesDb.)
                //Shoppers = _repo.GetUserDbs.Where(s => s.IsShop.Equals(true)).Include(se => se.ShopServicesDb)
                //AssignedTeches = _repo.GetAssignedTechDbs.Where(sp => sp.Service.UserId.Equals(int.Parse(Request.Cookies["UserID"]))).Include(se => se.Sho)
            };

            return View(shops);
            //return Content($"Here is your Vehicle: {int.Parse(vehicleID)}");
        }

        public async Task<IActionResult> VehReq(VehicleReqModel model)
        {
            return View();
        }
    }
}