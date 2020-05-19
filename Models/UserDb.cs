using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class UserDb
    {
        public UserDb()
        {
            MessageDb = new HashSet<MessageDb>();
            ServicedHistDb = new HashSet<ServicedHistDb>();
            ShopServicesDb = new HashSet<ShopServicesDb>();
            ShopTechDb = new HashSet<ShopTechDb>();
            UserVehDb = new HashSet<UserVehDb>();
            VehReqDb = new HashSet<VehReqDb>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserCountry { get; set; }
        public string UserDescription { get; set; }
        public int? ImageId { get; set; }
        public bool? IsShop { get; set; }

        public virtual UserImgDb Image { get; set; }
        public virtual ICollection<MessageDb> MessageDb { get; set; }
        public virtual ICollection<ServicedHistDb> ServicedHistDb { get; set; }
        public virtual ICollection<ShopServicesDb> ShopServicesDb { get; set; }
        public virtual ICollection<ShopTechDb> ShopTechDb { get; set; }
        public virtual ICollection<UserVehDb> UserVehDb { get; set; }
        public virtual ICollection<VehReqDb> VehReqDb { get; set; }
    }
}
