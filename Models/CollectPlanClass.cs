using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUSMDM.Models
{
    public class CollectPlanClass
    {
        public int IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public static List<CollectPlanClass> CollectPlans = new List<CollectPlanClass>
        {
            new CollectPlanClass {IdentityNumber= 1, Name = "test", Status = "Active", CreatedBy = "admin", CreatedOn = DateTime.Now, ModifiedBy = "admin", ModifiedOn = DateTime.Now }
        };
    }
}
