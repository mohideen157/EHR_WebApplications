using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using EHR_Webapp.Models;


namespace EHR_Webapp.Controllers
{
    public class SecondLandingController : Controller
    {
        public IActionResult SecondLanding(string UserId, string password)
        {
            // return View("../Program/Programcode");
            return View("../NewProgramCode/NewProgramCode");
        }
    }
}

