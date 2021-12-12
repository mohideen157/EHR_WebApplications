using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class CostCenterController : Controller
    {
        public IActionResult CostCenter()
        {

            return View("../Login/costcenter/CostCenter");
        }
    }
}