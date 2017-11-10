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
    /// Controller object for API.
    /// </summary>
    [Route("api")]
    public class APIController : Controller
    {
        /// <summary>
        /// Repository for songs.
        /// </summary>
        public SongRepository songRepository;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="songRepository">The song repository comes from Dependency Injection.</param>
        public APIController(SongRepository songRepository)
            => this.songRepository = songRepository;

        /// <summary>
        /// Lists all the songs (that are not deleted).
        /// </summary>
        /// <returns>JSON object with the songs.</returns>
        [HttpGet]
        [Route(""), Route("show")]
        public IActionResult List()
            => Json(songRepository.SongContext.Songs);

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
                return Json(new { command = "Show one song", song=songRepository.GetOneSong(id) });
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Adds a new song and returns the data of it as confirmation.
        /// </summary>
        /// <param name="song">Song object.</param>
        /// <returns>JSON object with the saved data.</returns>
        [Route("add")]
        [HttpPost]
        public IActionResult Add([FromBody] Song song)
        {
            songRepository.Add(song);
            return Json(new { command = "Add new song", song });
        }

        /// <summary>
        /// Updates an existing song and returns the data of it as confirmation.
        /// </summary>
        /// <param name="song">Song object with the new data.</param>
        /// <returns>JSON object with the updated data.</returns>
        [Route("update")]
        [HttpPatch]
        public IActionResult UpdateConfirmation(Song song)
        {
            if (ModelState.IsValid)
            {
                songRepository.Update(song);
                return View(song);
            }
            return Json(new { command = "Add existing song", song });
        }

        /// <summary>
        /// Deletes a song from collection (soft delete).
        /// </summary>
        /// <param name="id">The ID of the song to be deleted.</param>
        /// <returns>JSON object with confirmation.</returns>
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
            => Json(songRepository.ListOfAuthors());

        /// <summary>
        /// Returns a list of genres.
        /// </summary>
        /// <returns>List of the genres.</returns>
        [Route("list/genres")]
        public IActionResult ListOfGenres()
            => Json(songRepository.ListOfGenres());

        /// <summary>
        /// Returns a list of years.
        /// </summary>
        /// <returns>List of the years.</returns>
        [Route("list/years")]
        public IActionResult ListOfYears()
            => Json(songRepository.ListOfYears());

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
                return BadRequest(new { error = "Please provide an ID" });
            }
            else if (newRating < 1)
            {
                return BadRequest(new { error = "Please provide a valid rating, at least 1" });
            }
            else if (newRating > 5)
            {
                return BadRequest(new { error = "Please provide a valid rating, not more than 5" });
            }

            try
            {
                songRepository.ChangeRating(id, newRating);
                return Json(new { status = "Change song rating", id = id, rating = newRating });
            }
            catch (Exception e)
            {
                return BadRequest(new { error = e.Message });
            }
        }

        /// <summary>
        /// Lists the favorite songs.
        /// </summary>
        /// <param name="numberOfSongs">The number of songs to show.</param>
        /// <returns>View object with the list.</returns>
        [Route("list/favorites/{numberOfSongs}")]
        [HttpGet]
        public IActionResult ListFavorites(int numberOfSongs)
        {
            if (numberOfSongs == 0)
            {
                return BadRequest(new { error = "Please provide how many songs would you like to see" });
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
        [Route("list/author/{author}")]
        [HttpGet]
        public IActionResult ListSameAuthors(string author)
            => Json(songRepository.SongsFromSameAuthor(author));

        /// <summary>
        /// Lists all the not deleted songs of the same genre.
        /// </summary>
        /// <param name="genre">The genre (pop, rock, etc).</param>
        /// <returns>View object with the list.</returns>
        [Route("list/genre/{genre}")]
        [HttpGet]
        public IActionResult ListSameGenre(string genre)
        {
            return Json(songRepository.SongsFromSameGenre(genre));
        }

        /// <summary>
        /// Lists all the not deleted songs from the same year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>View object with the list.</returns>
        [Route("list/year/{year}")]
        [HttpGet]
        public IActionResult ListSameYear(int year) 
            => Json(songRepository.SongsFromSameYear(year));
    }
}
