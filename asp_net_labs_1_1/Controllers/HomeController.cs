using asp_net_labs_1_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace asp_net_labs_1_1.Controllers
{
    public class HomeController : Controller
    {
        private IDictionary<string, string> storage = new Dictionary<string, string>()
        {
            {"username1","qwerty1"},
            {"username2","qwerty2"},
            {"username3","qwerty3"},
            {"username4","qwerty4"},
            {"username5","qwerty5"},
            {"username6","qwerty6"},
            {"username7","qwerty7"},
            {"username8","qwerty8"},
            {"username9","qwerty9"},
            {"username10","qwerty10"}
        };


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var login = model.Login.ToLower();
                if (storage.ContainsKey(login) && storage[login] == model.Password)
                {
                    return RedirectToAction("Index");
                } else
                {
                    ModelState.AddModelError("","Логин или пароль введены неверно");
                }             
            } 
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
