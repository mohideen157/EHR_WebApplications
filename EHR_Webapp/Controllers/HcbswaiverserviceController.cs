using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class HcbswaiverserviceController : Controller
    {
        public IActionResult Hcbswavierservice()
        {
            return View("../Login/hcbswaiverservice/hcBswaiverservice");
        }
    }
}