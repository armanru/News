using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using News.Models;
using News.Models.DataBase;
using System.Diagnostics;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;      
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User user)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction("SignUpSuccess");
            }

            return View(user);
        }

        public IActionResult SignUpSuccess()
        {
            return View();
        }
       
    }
}
