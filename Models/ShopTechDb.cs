using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class ShopTechDb
    {
        public ShopTechDb()
        {
            AssignedTechDb = new HashSet<AssignedTechDb>();
        }

        public int TechnicianId { get; set; }
        public int? UserId { get; set; }
        public string TechnicianName { get; set; }
        public string TechnicianDescription { get; set; }

        public virtual UserDb User { get; set; }
        public virtual ICollection<AssignedTechDb> AssignedTechDb { get; set; }
    }
}
