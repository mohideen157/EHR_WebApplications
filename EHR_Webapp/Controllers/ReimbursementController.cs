using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EHR_Webapp.Controllers
{
    public class ReimbursementController : Controller
    {
        public IActionResult Reimbursement()
        {

            return View("../Login/Reimbursement/Reimbursement");
        }
        public IActionResult ReimbursementRate()
        {

            return View("../Login/Reimbursement/ReimbursementRate");
        }
        public IActionResult DiagnosisforReimbursement()
        {

            return View("../Login/Reimbursement/DiagnosisforReimbursement");
        }
        public IActionResult Credentialsclinicians()
        {

            return View("../Login/Reimbursement/Credentialsclinicians");
        }
        public IActionResult BillingUsage()
        {

            return View("../Login/Reimbursement/BillingUsage");
        }
        public IActionResult BillingInformation2()
        {

            return View("../Login/Reimbursement/BillingInformation2");
        }
        public IActionResult BillingInformation()
        {

            return View("../Login/Reimbursement/BillingInformation");
        }
        public IActionResult AccountingDetails()
        {

            return View("../Login/Reimbursement/AccountingDetails");
        }
    }
}