using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Location()
        {

            return View("../Login/locations/Location");
        }
    }
}