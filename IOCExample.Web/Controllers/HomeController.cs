using IOCExample.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IOCExample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonDataService _singletonDataService;
        
        public HomeController(ISingletonDataService singletonDataService)
        {
            _singletonDataService = singletonDataService;       
        }

        public IActionResult Index([FromServices]ISingletonDataService singletonDataService2)
        {
            ViewBag.Time1 = _singletonDataService.GetDateTime.TimeOfDay.ToString();

            ViewBag.Time2 = singletonDataService2.GetDateTime.TimeOfDay.ToString();
            return View();
        }

        public IActionResult Privacy()
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
