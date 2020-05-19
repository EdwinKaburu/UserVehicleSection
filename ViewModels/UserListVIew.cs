using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserVehicleSection.Models;

namespace UserVehicleSection.ViewModels
{
    public class UserListVIew
    {
        public IEnumerable<UserVehDb> UserVehDbs { get; set; }

        public UserDb User { get; set; }

        public IEnumerable<VehReqDb> UserReqDbs { get; set; }
        public IEnumerable<ServicedHistDb> ServicedHistDbs { get; set; }
        public IEnumerable<MessageDb> MessageDbs { get; set; }


    }
}
