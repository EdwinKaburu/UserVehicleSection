using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserVehicleSection.Models.APIAcess;

namespace UserVehicleSection.ViewModels
{
    public class ListView
    {
        public IEnumerable<Result> Results { get; set; }


        //[Display(Name = "Make")]
        [Required]
        public string VehMake { get; set; }


        //[Display(Name = "Model")]
        [Required]
        public string VehModel { get; set; }

        //[Display(Name = "Year")]
        [Required]
        public string VehYear { get; set; }


        //[Display(Name = "Mileage")]
        [Required]
        public int VehMileage { get; set; }

        //[Display(Name = "Vin Number")]
        [Required]
        public string VehVinNum { get; set; }

        public string redirectID { get; set; }
    }
}
