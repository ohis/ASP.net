using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using JsonData;

namespace MusicApi.Controllers {

    
    public class ArtistController : Controller {

        private List<Artist> allArtists;

        public ArtistController() {
            allArtists = JsonToFile<Artist>.ReadJson();
        }

        //This method is shown to the user navigating to the default API domain name
        //It just display some basic information on how this API functions
        [Route("")]
        [HttpGet]
        public string Index() {
            //String describing the API functionality
            string instructions = "Welcome to the Music API~~\n========================\n";
            instructions += "    Use the route /artists/ to get artist info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *RealName/{string}\n";
            instructions += "       *Hometown/{string}\n";
            instructions += "       *GroupId/{int}\n\n";
            instructions += "    Use the route /groups/ to get group info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *GroupId/{int}\n";
            instructions += "       *ListArtists=?(true/false)\n";
            return instructions;
        }

        //ArtistController test = new ArtistController();
       //List<Artist> s = test.allArtists;
      //  List<Artist> all = allArtists.Select(artist => artist.RealName).ToList();
        [HttpGet]
        [Route("artists")]
        public JsonResult art(){
          
          var artist = from u in allArtists
                       select new {u.ArtistName};

          
          return Json(artist);
        }

        [HttpGet]
        [Route("artists/name/{name}")]

        public JsonResult RetName(string name){
            IEnumerable<Artist> match = allArtists.Where(artist => artist.ArtistName.Equals(name));

            if(match == null){
                return Json("no name matches");
            }

            return Json(match);

        }

        [HttpGet]
        [Route("artists/realname/{name}")]

        public JsonResult realname(string name){
            IEnumerable<Artist> real = allArtists.Where(artist => artist.RealName.Equals(name));
            return Json(real);
        }

    }
}