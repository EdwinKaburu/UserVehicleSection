using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class MessageDb
    {
        public int MessageId { get; set; }
        public int? VehReqId { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }
        public DateTime? MessageDate { get; set; }

        public virtual UserDb User { get; set; }
        public virtual VehReqDb VehReq { get; set; }
    }
}
