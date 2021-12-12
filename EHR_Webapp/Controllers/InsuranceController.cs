using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class InsuranceController : Controller
    {
        public IActionResult Insurance()
        {

            return View("../Login/insurance/insurance");
        }
        public IActionResult Settingsheading()
        {

            return View("../Login/insurance/settingsheading");
        }
        public IActionResult Claimsubmissionrule()
        {

            return View("../Login/insurance/claimsubmissionrule");
        }
        public IActionResult Appealsubmissionrules()
        {

            return View("../Login/insurance/appealsubmissionrules");
        }
        public IActionResult Payereligibilityrequest()
        {

            return View("../Login/insurance/payereligibilityrequest");
        }
        public IActionResult Interchangedefinition()
        {

            return View("../Login/insurance/interchangedefinition");
        }
        public IActionResult Functionalgroupdefinition()
        {

            return View("../Login/insurance/functionalgroupdefinition");
        }
        public IActionResult Informationsourcedefinition2100a()
        {

            return View("../Login/insurance/informationsourcedefinition2100a");
        }
        public IActionResult Informationreceiverdefinition()
        {

            return View("../Login/insurance/informationreceiverdefinition");
        }
    }
}