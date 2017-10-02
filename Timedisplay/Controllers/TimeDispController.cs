using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeDispController.Controllers {
   public class TimeDispController : Controller{

       [HttpGet]
       [Route("")]

       public IActionResult index(){
           return View();
       }


   }

}