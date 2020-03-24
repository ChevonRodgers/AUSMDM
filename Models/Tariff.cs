using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUSMDM.Models
{
    public class TariffClass
    {
        public int IdentityNumber { get; set; }
      public string Name { get; set; }
        public string Status { get; set; }
        public int TI { get; set; }
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public static List<TariffClass> tariffs = new List<TariffClass>
        {
            new TariffClass {IdentityNumber=1,Name="KZN_Water_Tariffs",Status="Active",CreatedBy="admin",CreatedOn=DateTime.Now,ModifiedBy="admin",ModifiedOn=DateTime.Now}
        };
    }
}
