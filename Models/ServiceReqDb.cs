using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class ServiceReqDb
    {
        public int SerReqId { get; set; }
        public int? VehReqId { get; set; }
        public int? AssignId { get; set; }

        public virtual AssignedTechDb Assign { get; set; }
        public virtual VehReqDb VehReq { get; set; }
    }
}
