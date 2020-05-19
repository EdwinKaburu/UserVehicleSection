using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class UserVehDb
    {
        public UserVehDb()
        {
            VehReqDb = new HashSet<VehReqDb>();
        }

        public int VehicleId { get; set; }
        public int? UserId { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleYear { get; set; }
        public int? VehicleMileage { get; set; }
        public string VehicleVinNum { get; set; }

        public virtual UserDb User { get; set; }
        public virtual ICollection<VehReqDb> VehReqDb { get; set; }
    }
}
