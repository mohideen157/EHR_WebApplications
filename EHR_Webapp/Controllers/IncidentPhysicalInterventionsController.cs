﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class IncidentPhysicalInterventionsController : Controller
    {
        public IActionResult IncidentPhysicalInterventions()
        {

            return View("../Login/IncidentPhysicalInterventions/IncidentPhysicalInterventions");
        }
    }
}