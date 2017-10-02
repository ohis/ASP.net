using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace CallingCard.Controllers
{

    public class CardController : Controller
    {
     // string FirstName = "";
     /// string LastName = "";
     // string FavoriteColor ="";
      //int Age = 0;
         
      [HttpGet]
      [Route("{FirstName}/{LastName}/{FavoriteColor}/{Age}")]

      public JsonResult card(string FirstName,string LastName , string FavoriteColor ,int Age){
         var cards = new {
                FirstName ,
                LastName,
                Age ,
                FavoriteColor


          };

          return Json(cards);
      }
    }
}