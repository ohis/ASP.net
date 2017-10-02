using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 using System;
namespace json.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public JsonResult Example()
        {
            return Json("say hello");
        }
        [HttpGet]
        [Route("displayint")]
        public JsonResult Displayint(){
            var AnonObject = new {
                        FirstName = "Raz",
                        LastName = "Aquato",
                        Age = 10
            };

            return Json(AnonObject);
        }
    }
}
