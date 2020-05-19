using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class AssignedTechDb
    {
        public AssignedTechDb()
        {
            ServiceReqDb = new HashSet<ServiceReqDb>();
        }

        public int AssignId { get; set; }
        public int? TechnicianId { get; set; }
        public int? ServiceId { get; set; }

        public virtual ShopServicesDb Service { get; set; }
        public virtual ShopTechDb Technician { get; set; }
        public virtual ICollection<ServiceReqDb> ServiceReqDb { get; set; }
    }
}
