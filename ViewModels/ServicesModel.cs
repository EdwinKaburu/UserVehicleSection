using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserVehicleSection.ViewModels
{
    public class ServicesModel
    {
        //[Required]
        //public int ShopID { get; set; }

        [Required]
        public string ServiceName { get; set; }

        [Required]
        public decimal ServiceCost { get; set; }

        [Required]
        public string ServiceDescription { get; set; }
    }
}
