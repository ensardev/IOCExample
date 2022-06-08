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
        #region ISingletonDateService
        //private readonly ISingletonDataService _singletonDataService;

        //public HomeController(ISingletonDataService singletonDataService)
        //{
        //    _singletonDataService = singletonDataService;       
        //}

        //public IActionResult Index([FromServices]ISingletonDataService singletonDataService2)
        //{
        //    ViewBag.Time1 = _singletonDataService.GetDateTime.TimeOfDay.ToString();

        //    ViewBag.Time2 = singletonDataService2.GetDateTime.TimeOfDay.ToString();
        //    return View();
        //}
        #endregion

        #region IScopedDateService
        //private readonly IScopedDateService _scopedDateService;

        //public HomeController(IScopedDateService scopedDateService)
        //{
        //    _scopedDateService = scopedDateService;
        //}

        //public IActionResult Index([FromServices] IScopedDateService scopedDateService2)
        //{
        //    ViewBag.Time1 = _scopedDateService.GetDateTime.TimeOfDay.ToString();

        //    ViewBag.Time2 = scopedDateService2.GetDateTime.TimeOfDay.ToString();
        //    return View();
        //}
        #endregion

        #region ITransientDateService
        private readonly ITransientDateService _transientDateService;

        public HomeController(ITransientDateService transientDateService)
        {
            _transientDateService = transientDateService;
        }

        public IActionResult Index([FromServices] ITransientDateService transientDateService2)
        {
            ViewBag.Time1 = _transientDateService.GetDateTime.TimeOfDay.ToString();

            ViewBag.Time2 = transientDateService2.GetDateTime.TimeOfDay.ToString();
            return View();
        }
        #endregion


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
