using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class InsuranceslidingfeesController : Controller
    {
        public IActionResult Insuranceslidingfees()
        {

            return View("../Login/Insuranceslidingfees/Insuranceslidingfees");
        }
        public IActionResult SlidingFeesDefinition()
        {

            return View("../Login/Insuranceslidingfees/SlidingFeesDefinition");
        }
    }
}