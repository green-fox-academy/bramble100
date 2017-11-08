using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gamora.Repositories;
using Gamora.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gamora.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public SongRepository songRepository;

        public HomeController(SongRepository songRepository)
        {
            this.songRepository = songRepository;
        }

        [Route("")]
        [Route("awesome")]
        [HttpGet]
        public IActionResult Index()
        {
            return Json(songRepository.SongContext.Songs);
        }

        [Route("add")]
        [HttpPost]
        public IActionResult Add([FromBody] Song song)
        {
            songRepository.Add(song);
            return Json(new { status = "Add new song" , song});
        }

        [Route("remove")]
        [HttpDelete]
        public IActionResult Delete()
        {
            return Json(new { status = "Delete song" });
        }

        [Route("changerating")]
        [HttpPatch]
        public IActionResult ChangeRating()
        {
            return Json(new { status = "Change song rating" });
        }

        [Route("list/favorites")]
        [HttpPatch]
        public IActionResult ListFavorites()
        {
            return Json(new { status = "List favourite X songs" });
        }

        [Route("list/sameauthors")]
        [HttpPatch]
        public IActionResult ListSameAuthors()
        {
            return Json(new { status = "List songs by same author" });
        }

        [Route("list/samegenre")]
        [HttpPatch]
        public IActionResult ListSameGenre()
        {
            return Json(new { status = "List songs of same genre" });
        }

        [Route("list/sameyear")]
        [HttpPatch]
        public IActionResult ListSameYear()
        {
            return Json(new { status = "List songs from same year" });
        }
    }
}
