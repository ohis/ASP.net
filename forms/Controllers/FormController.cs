using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormController.Controllers{
    public class FormController : Controller{
        public int num;
        public string text;
        [HttpPost]
        [Route("method")]

        public IActionResult Method(string TextField, int NumberField){
           ViewBag.text = TextField;
           ViewBag.num = NumberField;
         
          return View();
        }
        
      
        [HttpGet]
        [Route("")]
        public IActionResult Method(){
           // ViewBag.Num = num;
          //  ViewBag.Text = TextField;
            return View();
        }

        public JsonResult Method(int Num){
            Num = num;
            return Json(Num);
        }
    }
}