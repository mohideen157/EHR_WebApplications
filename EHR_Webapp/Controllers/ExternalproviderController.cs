using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class ExternalproviderController : Controller
    {
        public IActionResult Contactinformation()
        {
            return View("../Login/externalprovider/externalprovide");
        }
        public IActionResult Pratice()
        {
            return View("../Login/externalprovider/externalprovide_practice");
        }
    }
}