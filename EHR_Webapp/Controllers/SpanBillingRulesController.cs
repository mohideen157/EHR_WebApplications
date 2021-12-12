using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class SpanBillingRulesController : Controller
    {
        public IActionResult SpanBillingRuleSet()
        {

            return View("../Login/SpanBillingRules/SpanBillingRuleSet");
        }
        public IActionResult SpanBillingRulesDefinition()
        {

            return View("../Login/SpanBillingRules/SpanBillingRulesDefinition");
        }
        public IActionResult SpanBillingMinimumRequirement()
        {

            return View("../Login/SpanBillingRules/SpanBillingMinimumRequirement");
        }
    }
}