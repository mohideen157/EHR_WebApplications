using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class DiagnosisCodesController : Controller
    {
        public IActionResult DiagnosisCodes()
        {

            return View("../Login/DiagnosisCodes/DiagnosisCodes");
        }
    }
}