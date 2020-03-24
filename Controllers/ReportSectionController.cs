using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AUSMDM.Controllers
{
    public class ReportSectionController : Controller
    {
        public IActionResult CollectionReport()
        {
            return View();
            
        }
        public IActionResult ArchiveReport()
        {
            return View();

        }
        public IActionResult PrePayReport()
        {
          return View();

        }
    }
}