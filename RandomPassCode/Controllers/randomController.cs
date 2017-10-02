using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;


namespace randomController.Controllers{

    public class randomController : Controller{
        public int count = 0;

        [HttpPost]
        [Route("code")]

        public IActionResult form(){
           // count+=1;
           
            return RedirectToAction("RandPassCode");
        }

        [HttpGet]
        [Route("")]
        public IActionResult RandPassCode(){
        
         ViewBag.Code = Generate();
         
         int? IntVariable = HttpContext.Session.GetInt32("num");

         if(IntVariable == null){
             IntVariable = 0;
         }
          IntVariable+=1;
         ViewBag.count = IntVariable;
          HttpContext.Session.SetInt32("num",(int)IntVariable);
         Console.WriteLine("tHE NUMBER OF COUNTS ARE "+IntVariable);
            return View("passCode");

        }

        public string Generate(){
            var Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randCode = new char[14];

            for(int i = 0; i < 14;i++){
                randCode[i] = Chars[random.Next(14)];
            }

           var code = new String(randCode);
           Console.WriteLine(code);
           return code;

        }
    }
}