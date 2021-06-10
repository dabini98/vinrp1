using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp_asp.Models;
using webapp_asp.Data; 
using Microsoft.AspNetCore.Http;

namespace webapp_asp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private LoginContext db = null;

        public HomeController(LoginContext db, ILogger<HomeController> logger)
        {
            this.db = db; 
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(String id, String password)
        {
            var member = db.Member.SingleOrDefault(a => a.id.Equals(id)); 
            if(member != null){
                if(password.Equals(member.password)) {
                 HttpContext.Session.SetString("id", id);
                 return Redirect("Index"); 
             }  
            }
            return null;
        }
        public IActionResult SignupPage()
        {
           return View(); 
        }
        public IActionResult SignUp(Member member){
              db.Member.Add(member);
              db.SaveChanges();
              return RedirectToAction("Index");
        }

         public IActionResult Logout()
        {
            HttpContext.Session.Remove("id");
            return RedirectToAction("Index");
        }
       public IActionResult AboutCompany()
       {
           return View();
       }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
