using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class RoundingRulesController : Controller
    {
        public IActionResult RoundingRules()
        {

            return View("../Login/RoundingRules/RoundingRules");
        }
        public IActionResult BillingRule()
        {

            return View("../Login/RoundingRules/Rountingrules_BillingRule");
        }
        public IActionResult ResidentialBillingRules()
        {

            return View("../Login/RoundingRules/Rountingrules_ResidentialBillingRules");
        }
        public IActionResult SupervisingClinicianBillingRequirements()
        {

            return View("../Login/RoundingRules/Rountingrules_SupervisingClinicianBillingRequirements");
        }
        public IActionResult DynamicDuplicateEncounterRules()
        {

            return View("../Login/RoundingRules/Routingrules_DynamicDuplicateEncounterRules");
        }
    }
}