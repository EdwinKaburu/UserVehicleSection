using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserVehicleSection.ViewModels
{
    public class VehicleModel
    {
        [Required]
        [Display(Name = "Make")]
        public string VehMake { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string VehModel  { get; set; }
        [Required]
        [Display(Name = "Year")]
        public string VehYear { get; set; }

        [Required]
        [Display(Name = "Mileage")]
        public int VehMileage { get; set; }
        [Required]
        [Display(Name = "Vin Number")]
        public string VehVinNum { get; set; }


    }
}
