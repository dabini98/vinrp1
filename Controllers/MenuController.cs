using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MenuContext = webapp_asp.Data.MenuContext;
using webapp_asp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace webapp_asp.Controllers
{

    public class MenuController : Controller
    {
        private readonly MenuContext context;

        public MenuController(MenuContext context){
            this.context = context;
        }
      
        public IActionResult Delivery()
        {
         return View(context.Menu.ToList()); 
        }
        public IActionResult Admin()
        {
            return View(context.Menu.ToList()); 
        }
         
        public IActionResult AddMenu() 
        {
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMenu(Menu menu)
        {
           context.Menu.Add(menu); 
           context.SaveChanges();
           return RedirectToAction("/Menu/Admin");
        }
        public async Task<IActionResult> EditMenu(string id) 
        {
            return View(await context.Menu.FindAsync(id)); 
        }
        public async Task<IActionResult> OrderMenu(string id)
        {
            return View(await context.Menu.FindAsync(id)); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OrderMenu(string id, Menu menu)
        {
            if(menu.number != id)
            {
                return null;
            }
            else
            {
               
                menu.amount = menu.amount -1;
                menu.sales = menu.sales + 1; 
                context.Menu.Update(menu);
                context.SaveChanges();
                return Redirect("/Menu/OrderSuccess");
            } 
        }

        public IActionResult OrderSuccess()
        {
            return View();
        }
        public IActionResult AboutMenu()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
         public IActionResult EditMenu(string id, Menu menu) 
        {
            if(id != menu.number)
            {
                return null; 
            }
            else 
            {
              context.Menu.Update(menu);
              context.SaveChanges();
              return Redirect("/Menu/Admin"); 
            } 
        }
        public IActionResult DeleteMenu(string id)
        {
           return View(context.Menu.Find(id)); 
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMenu(string id, Menu menu)
        {
            if(id != menu.number)
            {
                return null; 
            }
            else 
            {
                context.Menu.Remove(menu);
                context.SaveChanges();
                return Redirect("/Menu/Admin"); 
            }
        }
        
        public IActionResult CaluSales(string id)
        {
            return View(context.Menu.Find(id));
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CaluSales2(string id, Menu menu)
        {
            int totalsales;
            if(menu.number != id) return null;
            else 
            {
                totalsales = menu.price * menu.sales;
                HttpContext.Session.SetInt32("totalsales", totalsales);
                return Redirect("/Menu/CaluSales/" + id);
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
