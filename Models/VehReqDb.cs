using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class VehReqDb
    {
        public VehReqDb()
        {
            MessageDb = new HashSet<MessageDb>();
            ServiceReqDb = new HashSet<ServiceReqDb>();
            ServicedHistDb = new HashSet<ServicedHistDb>();
        }

        public int VehReqId { get; set; }
        public int? VehicleId { get; set; }
        public string VehReqName { get; set; }
        public DateTime? VehReqDate { get; set; }
        public int? UserId { get; set; }
        public string VehReqMessage { get; set; }

        public virtual UserDb User { get; set; }
        public virtual UserVehDb Vehicle { get; set; }
        public virtual ICollection<MessageDb> MessageDb { get; set; }
        public virtual ICollection<ServiceReqDb> ServiceReqDb { get; set; }
        public virtual ICollection<ServicedHistDb> ServicedHistDb { get; set; }
    }
}
