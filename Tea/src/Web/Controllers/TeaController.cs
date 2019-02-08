using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class    TeaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TajMahal()
        {
            return Json(new { success = true, brand="TajMahal",type="JSON"});
        }
        // public IActionResult TajMahal()
        // {
        //     return View();
        // }
//  public IActionResult RedRoses()
//         {
//             return View();
//         }
        public IActionResult RedRoses()
        {
            return Content("RedRoses is the best taste.")
        }
         public IActionResult Gemini()
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
