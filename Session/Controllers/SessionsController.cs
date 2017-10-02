using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SessionsController.Controllers{

    public class SessionsController : Controller{

        [HttpGet]
        [Route("")]

        public IActionResult Method(){
            return RedirectToAction("OtherMethod", new { Food = "sandwiches",Quantity = 5});

        }

        [HttpGet]
        [Route("other/{Food}")]

        public IActionResult OtherMethod(string Food, int Quantity){

            Console.WriteLine($"I ate {Quantity} {Food}");
            return View();
        }
    }
}