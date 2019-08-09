using System;
using Microsoft.AspNetCore.Mvc;

namespace HelloASP
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }


        [HttpGet("projects")]
        public ViewResult projects()
        {
            // redirect to localhost:5000
            return View("projects");
        }


        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View("contact");
        }


    }
}