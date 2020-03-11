using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AUSMDM.Controllers
{
    public class SystemSectionController : Controller
    {
        public IActionResult Index()
        {
            //This is a comment
            return View();
        }
    }
}