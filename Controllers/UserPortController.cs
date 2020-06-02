using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
             */
            
            var getuser = _repo.GetUserDbs.Where(s => s.UserId.Equals(int.Parse(userID))).Include(s => s.Image).FirstOrDefault();

            var userVehReq = _repo.GetUserVehs.Where(s => s.UserId.Equals(int.Parse(userID)))
                .Include(sp => sp.VehReqDb).ThenInclude(ap => ap.ServicedHistDb);

            var VehReqSection = _repo.GetVehReqs.Include(sp => sp.User).Include(p => p.MessageDb).Include(o => o.ServicedHistDb)
               .Include(sp => sp.Vehicle).ThenInclude(sp => sp.User).Where(a => a.Vehicle.UserId.Equals(int.Parse(userID)));


            var vehServicedHist = _repo.GetServicedHists.Include(sp => sp.VehReq).ThenInclude(uv => uv.Vehicle)
                .Where(ap => ap.VehReq.Vehicle.UserId.Equals(int.Parse(userID)));

            var message = _repo.GetMessages.Include(ap => ap.VehReq)
                .Include(ap => ap.VehReq.ServicedHistDb).Include(ap => ap.VehReq.User).Include(sp => sp.VehReq.ServiceReqDb).ThenInclude(sa => sa.Assign.Service)
                .Include(ap => ap.VehReq.Vehicle).ThenInclude(sp => sp.User)
                .Where(a => a.VehReq.Vehicle.User.UserId.Equals(int.Parse(userID)));


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
    }
}
