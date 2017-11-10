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
                return RedirectToRoute("/error/");
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

    }
}
