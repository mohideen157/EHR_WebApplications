using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using EHR_Webapp.Models;

namespace EHR_Webapp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login(string UserId, string password)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:1484/api//");
            var parametersN = new Dictionary<string, string> { { "param1", "1" }, { "param2", "2" } };
            var responseTask = client.GetAsync("values");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, client.BaseAddress);

            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {

                ViewBag.UserId = UserId;
                ViewBag.Password = password;
                if (UserId == "sasi@abc.com")
                {
                   return View("Landing"); 
                }
                else if (UserId == "kumar@abc.com")
                {
                    return View("NewLanding");
                }
            }
            else
            {
                return View("Login");
            }
            return View();
        }
    }
}