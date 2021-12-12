using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class SISLEVELController : Controller
    {
        public IActionResult SISLEVEL()
        {

            return View("../Login/SISLEVEL/SISLEVEL");
        }
    }
}