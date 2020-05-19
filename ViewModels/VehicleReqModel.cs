using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserVehicleSection.Models;

namespace UserVehicleSection.ViewModels
{
    public class VehicleReqModel
    {
        public IEnumerable<UserDb> Shoppers { get; set; }

        public int VehicleID { get; set; }

        public int VehID { get; set; }

        public string VehReqName { get; set; }

        public DateTime VehdateTime { get; set; }

        //Shop User
        public int UserID { get; set; }

        public string VehMessage { get; set; }

        public UserDb GetUser { get; set; }

        public IEnumerable<ShopServicesDb> ShopServices { get; set; }

        public IEnumerable<AssignedTechDb> AssignedTeches { get; set; }

        public IEnumerable<CheckBoxItem> CheckBoxItems { get; set; }

       // public IEnumerable<CheckBoxItem> CheckedServices { get; set; }
    }
    
}
