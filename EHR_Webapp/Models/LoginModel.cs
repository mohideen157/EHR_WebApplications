using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EHR_Webapp.Models
{
    public class LoginModel
    {
        public string UserId { get; set; }
        public string Password { get; set; }
    }


    public class ProgramModel
    {
        [Display(Name =  "Enter Pcode")]
        public string ProgramCode { get; set; }

        [Display(Name = "Enter PName")]
        public string ProgramName { get; set; }

        [Display(Name = "Enter Wiaver")]
        public string Programwaiver { get; set; }
    }

}