using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Service()
        {
            return View("../Login/services/Service");
        }
        public IActionResult ServiceRate()
        {
            return View("../Login/services/ServiceRate");
        }
        public IActionResult Censusdayssetting()
        {
            return View("../Login/services/Censusdayssetting");
        }
        public IActionResult ServiceValidationRules()
        {
            return View("../Login/services/ServiceValidationRules");
        }
    }
}