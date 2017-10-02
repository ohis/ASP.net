using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

 namespace PortFController.Controllers
{
    public class PortFController : Controller{

        [HttpGet]
        [Route("")]

        public IActionResult index(){

            return View();
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult projects(){
            return View();
        }

    }
}