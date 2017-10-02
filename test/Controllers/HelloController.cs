using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace test.Controllers
{
    public class HelloController : Controller
    {
       // [HttpGetAttribute]
      [HttpGet]
      [Route("")]
       public string Index()
        {
            return "Hello World!";
        }
    }
}
