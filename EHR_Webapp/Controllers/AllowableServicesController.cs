using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class AllowableServicesController : Controller
    {
        public IActionResult Allowableservices()
        {
            return View("../Login/allowableservices/allowableservicesnewpage1");
        }
    }
}