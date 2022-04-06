using asp_net_labs_1_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Globalization;

namespace asp_net_labs_1_2.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.IsChecked = false;
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserViewModel model)
        {
            ViewBag.IsChecked = false;
            if (ModelState.IsValid)
            {
                ViewBag.IsChecked = true;
            }
            return View(model);
        }

    }

}
