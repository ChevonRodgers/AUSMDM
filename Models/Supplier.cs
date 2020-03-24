using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Razor;

namespace AUSMDM.Models
{
    public class Users
    {
        public string Name { get; set; }
        
           
        public string Surname { get; set; }

        [Key]
        public string IdentityNumber { get; set; }


   

        public static List<Users> AllUsers = new List<Users>
        {
            new Users {Name="Chevon",Surname="Rogers",IdentityNumber="0"},
            new Users {Name="Devon",Surname="rungasamt",IdentityNumber="1"}


           

            
        };
   



    }
}
