using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SurveyController.Controllers{
    public class SurveyController : Controller{
        [HttpGet]
        [Route("")]

        public IActionResult index(){
            return View("index");
        }
        [HttpPost]
        [Route("index")]
        public IActionResult index(string name,string Location,string language,string comment){
             ViewBag.name = name;
             ViewBag.Location = Location;
             ViewBag.language = language;
             ViewBag.comment = comment;
            return View("result");
        }

        [HttpGet]
        [Route("result")]
         public IActionResult result(){
            
            return View("result");
        }
    }
}