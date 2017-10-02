using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloController.Controllers{

    public class HelloController : Controller{

        [HttpGet]
        [Route("")]

        public IActionResult Index(){
            return View();
        }

    }

}