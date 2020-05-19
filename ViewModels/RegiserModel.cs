using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserVehicleSection.ViewModels
{
    public class RegiserModel
    {
        [Display(Name = "Auto-Shop Registration")]
        public bool IsShop { get; set; }

        [Required]
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        [Required]
        [Display(Name = "Account Email")]
        public string AccountEmail { get; set; }

        [Required]
        [Display(Name = "Account Password")]
        public string AccountPassword { get; set; }

        [Required]
        [Display(Name = "Account Address")]
        public string AccountAddress { get; set; }

        [Required]
        [Display(Name = "Account City")]
        public string AccountCity { get; set; }

        [Required]
        [Display(Name = "Account Country")]
        public string AccountCountry { get; set; }

        [Required]
        [Display(Name = "Account Description")]
        public string AccountDescription { get; set; }

        [Required]
        [Display(Name = "Image")]
        public IFormFile ImgPic { get; set; }
    }
}
