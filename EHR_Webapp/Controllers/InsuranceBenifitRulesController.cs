using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class InsuranceBenifitRulesController : Controller
    {
        public IActionResult InsuranceBenifitRuless()
        {

            return View("../Login/InsuranceBenifitRules/InsuranceBenifitRules");
        }
    }
}