using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class CopyofserviceController : Controller
    {
        public IActionResult Copyofservice()
        {
            return View("../Login/copyofservice/copyofservice");
        }
        public IActionResult ServiceRate()
        {
            return View("../Login/copyofservice/copyofservice_servicerate");
        }
        public IActionResult Servicevalidationrules()
        {
            return View("../Login/copyofservice/copyofservice_servicevalidationrules");
        }
        public IActionResult Censusdayssettings()
        {
            return View("../Login/copyofservice/copyofservice_censusdayssettings");
        }
    }
}