using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AUSMDM.Controllers
{
    public class AnalysisSectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}