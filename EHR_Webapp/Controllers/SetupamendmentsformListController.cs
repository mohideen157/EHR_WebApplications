﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class SetupamendmentsformListController : Controller
    {
        public IActionResult SetupamendmentsformList()
        {

            return View("../Login/SetupamendmentsformList/SetupamendmentsformList");
        }
    }
}