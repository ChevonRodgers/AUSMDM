using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AUSMDM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AUSMDM.Controllers
{
    public class RemotingSectionController : Controller
    {
        private readonly ILogger<RemotingSectionController> _logger;

        public RemotingSectionController(ILogger<RemotingSectionController> logger)
        {
            _logger = logger;
        }
        public IActionResult _RealtimeOperating()
        {
            return View();
        }

        public IActionResult _Reading()
        {
            return View();
        }

        public IActionResult _EmergencyLoadControl()
        {
            return View();
        }

        public IActionResult _TariffUpdateResult()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}