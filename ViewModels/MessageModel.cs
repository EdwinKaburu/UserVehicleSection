using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserVehicleSection.ViewModels
{
    public class MessageModel
    {
        //Customer or User
        public int? VehReqID { get; set; }

        //Store
        public int? UserID { get; set; }

        public string TextMessage { get; set; }

        public DateTime DateMessage { get; set; }
    }
}
