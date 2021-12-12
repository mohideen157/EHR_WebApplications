using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class SetupProblemCodesController : Controller
    {
        public IActionResult SetupProblemCodes()
        {

            return View("../Login/SetupProblemCodes/SetupProblemCodes");
        }
    }
}