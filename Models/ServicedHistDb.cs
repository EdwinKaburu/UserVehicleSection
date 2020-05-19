using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class ServicedHistDb
    {
        public int HistoryId { get; set; }
        public int? VehReqId { get; set; }
        public decimal? Cost { get; set; }
        public bool? Serviced { get; set; }
        public int? UserId { get; set; }

        public virtual UserDb User { get; set; }
        public virtual VehReqDb VehReq { get; set; }
    }
}
