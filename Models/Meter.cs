using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AUSMDM.Models
{
    public class Meter
    {
        public int IdentityNumber { get; set; }
        public string Name { get; set; }
        [Required]
        public string Supplier { get; set; }

        public string Protocol { get; set; }

        public string ConnectionType { get; set; }

        public double Accuracy { get; set; }

        public int Voltage { get; set; }

        public int CurrentGrade { get; set; }

        public string CreditType{ get; set; }

       

        public static List<Meter> AllMeters = new List<Meter>
        {
            new Meter{IdentityNumber=1,Name="Meter",Supplier="Supplier",Protocol="Protocol",ConnectionType="Connection",Accuracy=1.1,Voltage=240,CurrentGrade=10,CreditType="Prepay"}
        };
    }
}
