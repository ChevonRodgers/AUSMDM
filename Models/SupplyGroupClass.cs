using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUSMDM.Models
{
    public class SupplyGroupClass
    {
        public int IdentityNumber { get; set; }
        public string Name { get; set; }
        public int SGC { get; set; }
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public static List<SupplyGroupClass> SupplyGroups = new List<SupplyGroupClass>
        {
            new SupplyGroupClass {Name="Joy_Meter",SGC= 500,CreatedBy="aus",CreatedOn=DateTime.Now,ModifiedBy="aus",ModifiedOn=DateTime.Now}
        };
    }
}
