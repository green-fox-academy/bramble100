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
    /// <summary>
    /// Controller object for HTML pages.
    /// </summary>
    [Route("")]
    public class HomeController : Controller
    {
        /// <summary>
        /// Repository for songs.
        /// </summary>
        public SongRepository songRepository;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="songRepository">The song repository comes from Dependency Injection.</param>
        public HomeController(SongRepository songRepository)
            => this.songRepository = songRepository;

        /// <summary>
        /// Lists all the songs (that are not deleted).
        /// </summary>
        /// <returns>View object with the songs.</returns>
        [HttpGet]
        [Route(""), Route("show")]
        public IActionResult List()
            => View(songRepository.SongContext.Songs);

        /// <summary>
        /// Lists one song (if not deleted).
        /// </summary>
        /// <param name="id">The ID of the requested number.</param>
        /// <returns>View object with the song.</returns>
        [Route("show/{id}")]
        [HttpGet]
        public IActionResult List(int id)
        {
            try
            {
                return View("ShowOne", songRepository.GetOneSong(id));
            }
            catch (Exception)
            {
                return RedirectToRoute("/error/");
            }
        }

        /// <summary>
        /// Shows a form for adding a new song.
        /// </summary>
        /// <returns>View object with the form.</returns>
        [Route("add")]
        [HttpGet]
        public IActionResult AddForm() => View(new Song());

        /// <summary>
        /// Gives a confirmation with the added song's data.
        /// </summary>
        /// <param name="song">Empty Song object.</param>
        /// <returns>View object with the confirmation.</returns>
        [Route("add")]
        [HttpPost]
        public IActionResult AddConfirmation(Song song)
        {
            if (!ModelState.IsValid)
            {
                songRepository.Add(song);
                return View(song);
            }
            return View("AddForm", song);
        }

        /// <summary>
        /// Shows a form for updating a new song.
        /// </summary>
        /// <returns>View object with the form.</returns>
        [Route("update/{id}")]
        [HttpGet]
        public IActionResult UpdateForm(int id)
        {
            try
            {
                return View(songRepository.GetOneSong(id));
            }
            catch (Exception)
            {
                return RedirectToRoute("/error/");
            }
        }

        /// <summary>
        /// Gives a confirmation with the song's updated data.
        /// </summary>
        /// <param name="song">Empty Song object.</param>
        /// <returns>View object with the confirmation.</returns>
        [Route("update")]
        [HttpPost]
        public IActionResult UpdateConfirmation(Song song)
        {
            if (ModelState.IsValid)
            {
                songRepository.Update(song);
                return View(song);
            }
            return View("UpdateForm", song);
        }

        /// <summary>
        /// Deletes a song from collection (soft delete).
        /// </summary>
        /// <param name="id">The ID of the song to be deleted.</param>
        /// <returns>View object with confirmation.</returns>
        [Route("delete/{id}")]
        [HttpDelete]
        public IActionResult DeleteConfirmation(int id)
        {
            try
            {
                songRepository.DeleteSong(id);
                var song = songRepository.LastDeletedSong;
                return View(song);
            }
            catch (Exception)
            {
                return RedirectToRoute("error");
            }
        }

        /// <summary>
        /// Returns a list of authors.
        /// </summary>
        /// <returns>List of the authors.</returns>
        [Route("list/authors")]
        public IActionResult ListOfAuthors() 
            => View(songRepository.ListOfAuthors());

        /// <summary>
        /// Returns a list of genres.
        /// </summary>
        /// <returns>List of the genres.</returns>
        [Route("list/genres")]
        public IActionResult ListOfGenres()
            => View(songRepository.ListOfGenres());

        /// <summary>
        /// Returns a list of years.
        /// </summary>
        /// <returns>List of the years.</returns>
        [Route("list/years")]
        public IActionResult ListOfYears()
            => View(songRepository.ListOfYears());

        /// <summary>
        /// Change the rating of a song.
        /// </summary>
        /// <param name="id">The ID of the song.</param>
        /// <param name="newRating">The new rating.</param>
        /// <returns>View object.</returns>
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

        /// <summary>
        /// Lists the favorite songs.
        /// </summary>
        /// <param name="numberOfSongs">The number of songs to show.</param>
        /// <returns>View object with the list.</returns>
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

        /// <summary>
        /// Lists all the not deleted songs from the same author.
        /// </summary>
        /// <param name="author">The name of the author.</param>
        /// <returns>View object with the list.</returns>
        [Route("list/sameauthor/{author?}")]
        [HttpGet]
        public IActionResult ListSameAuthors(string author) 
            => View(songRepository.SongsFromSameAuthor(author));

        /// <summary>
        /// Lists all the not deleted songs of the same genre.
        /// </summary>
        /// <param name="genre">The genre (pop, rock, etc).</param>
        /// <returns>View object with the list.</returns>
        [Route("list/samegenre")]
        [HttpGet]
        public IActionResult ListSameGenre(string genre)
        {
            return Json(new { status = "List songs of same genre" });
        }

        /// <summary>
        /// Lists all the not deleted songs from the same year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>View object with the list.</returns>
        [Route("list/sameyear")]
        [HttpGet]
        public IActionResult ListSameYear(int year)
        {
            return Json(new { status = "List songs from same year" });
        }

    }
}
