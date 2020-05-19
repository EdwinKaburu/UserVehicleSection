using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class ShopServicesDb
    {
        public ShopServicesDb()
        {
            AssignedTechDb = new HashSet<AssignedTechDb>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? UserId { get; set; }
        public decimal? ServiceCost { get; set; }
        public string ServiceDescription { get; set; }

        public virtual UserDb User { get; set; }
        public virtual ICollection<AssignedTechDb> AssignedTechDb { get; set; }
    }
}
