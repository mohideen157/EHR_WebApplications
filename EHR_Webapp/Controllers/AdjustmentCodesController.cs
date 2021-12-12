using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class AdjustmentCodesController : Controller
    {
        public IActionResult AdjustmentCodes()
        {

            return View("../Login/AdjustmentCodes/AdjustmentCodes");
        }
    }
}