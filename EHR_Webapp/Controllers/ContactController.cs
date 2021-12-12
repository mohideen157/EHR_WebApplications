using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult General()
        {
            return View("../Login/contact/contact_general");
        }
        public IActionResult Billingdetails()
        {
            return View("../Login/contact/contact_billingdetails");
        }
        public IActionResult Definitionbylocation()
        {
            return View("../Login/contact/contact_definitionbylocation");
        }
        public IActionResult Billingtemplate()
        {
            return View("../Login/contact/contact_billingtemplate");
        }
    }
}