using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUSMDM.Models
{
    public class FeeModel
    {
        public int IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public static List<FeeModel> FeeList = new List<FeeModel>
        {
            new FeeModel {IdentityNumber= 1, Name = "pool", Status = "Active", CreatedBy = "admin", CreatedOn = DateTime.Now, ModifiedBy = "admin", ModifiedOn = DateTime.Now }
        };
    }
}


