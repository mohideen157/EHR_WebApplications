using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class ProgCodeController : Controller
    {
        public IActionResult ProgCode()
        {
            
            return View("../Login/program/ProgCode");
        }
        public IActionResult ProgramDocumentation()
        {
            return View("../Login/program/ProgramDocumentation");
        }
        public IActionResult ConflictingProgram()
        {
            return View("../Login/program/conflictingprogram");
        }

        public IActionResult AllowableService()
        {
            return View("../Login/program/allowableservice");
        }
        public IActionResult ProgramBilling()
        {
            return View("../Login/program/ProgramBilling");
        }
    }
}