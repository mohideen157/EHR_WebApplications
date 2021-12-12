using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Company()
        {

            return View("../Login/company/Company");
        }
    }
}