﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class RucodeDenfinitionController : Controller
    {
        public IActionResult Rucode()
        {
            return View("../Login/rucodedefinition/rucode");
        }
    }
}