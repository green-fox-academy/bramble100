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
            return Json(new { status = "Add new song", song });
        }

        [Route("remove")]
        [HttpDelete]
        public IActionResult Delete()
        {
            return Json(new { status = "Delete song" });
        }

        [Route("changerating/{id?}/{newrating?}")]
        [HttpGet]
        public IActionResult ChangeRating(int id, int newRating)
        {
            if (id == 0)
            {
                return Json(new { error = "Please provide an ID" });
            }
            else if (newRating < 1)
            {
                return Json(new { error = "Please provide a valid rating, at least 1" });
            }
            else if (newRating > 5)
            {
                return Json(new { error = "Please provide a valid rating, not more than 5" });
            }

            try
            {
                songRepository.ChangeRating(id, newRating);
                return Json(new { status = "Change song rating", id = id, rating = newRating });
            }
            catch (Exception e)
            {
                return Json(new { error = e.Message });
            }
        }

        [Route("list/favorites/{numberOfSongs?}")]
        [HttpGet]
        public IActionResult ListFavorites(int numberOfSongs)
        {
            if (numberOfSongs == 0)
            {
                return Json(new { error = "Please provide how many songs would you like to see" });
            }

            return Json(new
            {
                status = $"List favourite {numberOfSongs} songs",
                favouriteSongs = songRepository.FavouriteSongs(numberOfSongs)
            });
        }

        [Route("list/sameauthors/{author?}")]
        [HttpGet]
        public IActionResult ListSameAuthors(string author)
        {
            return Json(new
            {
                status = "List songs by same author",
                songs = songRepository.SongsFromSameAuthor(author)
            });
        }

        [Route("list/samegenre")]
        [HttpGet]
        public IActionResult ListSameGenre()
        {
            return Json(new { status = "List songs of same genre" });
        }

        [Route("list/sameyear")]
        [HttpGet]
        public IActionResult ListSameYear()
        {
            return Json(new { status = "List songs from same year" });
        }
    }
}
