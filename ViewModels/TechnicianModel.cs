using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserVehicleSection.Models;

namespace UserVehicleSection.ViewModels
{
    public class TechnicianModel
    {
        //[Required]
        //public int ShopID { get; set; }
        public IEnumerable<ShopServicesDb> ShopServices { get; set; }

        public string UserCookie { get; set; }

        [Required]
        public string TechnicianName { get; set; }

        [Required]
        public string TechnicianDescription { get; set; }

        
        public string AssignedService { get; set; }

        public IEnumerable<ShopTechDb> TechDbs { get; set; }

        [Required]
        public string TechName { get; set; }
    }
}
