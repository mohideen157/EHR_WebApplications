using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class TreatmetPlanOptionsController : Controller
    {
        public IActionResult Dimension()
        {

            return View("../Login/TreatmetPlanOptions/Dimension");
        }
        public IActionResult Definition()
        {

            return View("../Login/TreatmetPlanOptions/Definition");
        }
        public IActionResult Goal()
        {

            return View("../Login/TreatmetPlanOptions/Goal");
        }
        public IActionResult Intervention()
        {

            return View("../Login/TreatmetPlanOptions/Intervention");
        }
        public IActionResult Objective()
        {

            return View("../Login/TreatmetPlanOptions/Objective");
        }
        public IActionResult Problem()
        {

            return View("../Login/TreatmetPlanOptions/Problem");
        }
        public IActionResult Relationships()
        {

            return View("../Login/TreatmetPlanOptions/Relationships");
        }
    }
}