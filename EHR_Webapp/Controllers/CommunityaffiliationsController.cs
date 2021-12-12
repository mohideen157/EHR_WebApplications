using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class CommunityaffiliationsController : Controller
    {
        public IActionResult Communityaffiliations()
        {
            return View("../Login/communityaffiliations/communityaffiliations");
        }
        public IActionResult Contact()
        {
            return View("../Login/communityaffiliations/communityaffiliations_contacts");
        }
    }
}