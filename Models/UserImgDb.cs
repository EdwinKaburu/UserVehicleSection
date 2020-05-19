using System;
using System.Collections.Generic;

namespace UserVehicleSection.Models
{
    public partial class UserImgDb
    {
        public UserImgDb()
        {
            UserDb = new HashSet<UserDb>();
        }

        public int ImageId { get; set; }
        public byte[] UserImg { get; set; }

        public virtual ICollection<UserDb> UserDb { get; set; }
    }
}
