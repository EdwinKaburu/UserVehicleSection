using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserVehicleSection.Models;

namespace UserVehicleSection.ViewModels
{
    public class ShopListView
    {
        public UserDb User { get; set; }
        public IEnumerable<ShopTechDb> ShopTeches { get; set; }

        public IEnumerable<ShopServicesDb> ShopServices { get; set; }

        public IEnumerable<AssignedTechDb> AssignedTeches { get; set; }

        public IEnumerable<MessageDb> ShopMessages { get; set; }

        public IEnumerable<ServicedHistDb> ShopServicedHists { get; set; }

        public IEnumerable<AssignedTechDb> ShopReqAssignedTeches { get; set; }

        public IEnumerable<VehReqDb> ShopReqVehDbs { get; set; }

        public IEnumerable<ServiceReqDb> ShopserviceReqs { get; set; }

        public IEnumerable<UserVehDb> VehDbs { get; set; }

        public UserDb UserReq { get; set; }
        
        public MessageModel MessageModel { get; set; }
    }
}
