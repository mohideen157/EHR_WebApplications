using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class DiagnosisCodesDSM5Controller : Controller
    {
        public IActionResult DiagnosisCodesDSM5()
        {

            return View("../Login/DiagnosisCodesDSM5/DiagnosisCodesDSM5");
        }
    }
}