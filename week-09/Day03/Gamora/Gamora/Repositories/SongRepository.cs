using Gamora.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamora.Models;

namespace Gamora.Repositories
{
    /// <summary>
    /// Repository for songs in the SQL database.
    /// </summary>
    public class SongRepository
    {
        /// <summary>
        /// SongContext object.
        /// </summary>
        public SongContext SongContext { get; set; }

        /// <summary>
        /// Keeps track of the last deleted song.
        /// </summary>
        public object LastDeletedSong { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="songContext">The song context comes from Dependency Injection.</param>
        public SongRepository(SongContext songContext) 
            => SongContext = songContext;

        /// <summary>
        /// Adds a new song with the given properties.
        /// </summary>
        /// <param name="song">Song object with the given properties.</param>
        public void Add(Song song)
        {
            SongContext.Add(song);
            SongContext.SaveChanges();
        }

        public void ChangeRating(int id, int newRating)
        {
            Song song = SongContext.Find<Song>(id);
            if (song == null)
            {
                throw new ArgumentException($"Song with id {id} not found");
            }
            song.Rating = newRating;
            SongContext.Update(song);
            SongContext.SaveChanges();
        }

        /// <summary>
        /// Gets one song with the given ID.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>Song object.</returns>
        public Song GetOneSong(int id)
        {
            var song = SongContext.Songs.Find(id);
            if (song != null)
            {
                return song;
            }
            throw new ArgumentException($"Song with id {id} not found");
        }

        public IQueryable<Song> FavouriteSongs(int numberOfSongs)
            => SongContext
                .Songs
                .OrderBy(s => s.Rating)
                .Reverse()
                .Take(numberOfSongs);

        /// <summary>
        /// Updates a song with properties in the given Song object.
        /// </summary>
        /// <param name="song">Song object, which contains the ID and the new properties.</param>
        public void Update(Song song)
        {
            SongContext.Update(song);
            SongContext.SaveChanges();
        }

        /// <summary>
        /// Deletes a song with a given ID (soft delete).
        /// </summary>
        /// <param name="id"></param>
        public void DeleteSong(int id)
        {
            var song = SongContext.Songs.Find(id);
            if (song != null)
            {
                song.IsDeleted = true;
                SongContext.Update(song);
                SongContext.SaveChanges();
            }
            throw new ArgumentException($"Song with id {id} not found");
        }

        /// <summary>
        /// Returns a list with the names of the authors.
        /// </summary>
        /// <returns>List with the names of the authors.</returns>
        public HashSet<string> ListOfAuthors()
            => new HashSet<string>(
                from song in SongContext.Songs
                where song.IsDeleted == false
                orderby song.Author
                select song.Author);

        /// <summary>
        /// Returns a list with the names of the genres.
        /// </summary>
        /// <returns>List with the names of the genres.</returns>
        public HashSet<string> ListOfGenres()
            => new HashSet<string>(
                from song in SongContext.Songs
                where song.IsDeleted == false
                orderby song.Genre
                select song.Genre);

        /// <summary>
        /// Returns a list with the names of the years.
        /// </summary>
        /// <returns>List with the names of the years.</returns>
        public HashSet<int> ListOfYears()
            => new HashSet<int>(
                from song in SongContext.Songs
                where song.IsDeleted == false
                orderby song.Year
                select song.Year);

        /// <summary>
        /// Returns a list with all the not deleted songs from the same author.
        /// </summary>
        /// <param name="author">The name of the author.</param>
        /// <returns>HashSet object with the list.</returns>
        public HashSet<Song> SongsFromSameAuthor(string author)
            => new HashSet<Song>(
                from song in SongContext.Songs
                where song.IsDeleted == false && song.Author == author
                orderby song.Id
                select song);

        /// <summary>
        /// Returns a list with all the not deleted songs from the same genre.
        /// </summary>
        /// <param name="genre">The name of the genre.</param>
        /// <returns>HashSet object with the list.</returns>
        public HashSet<Song> SongsOfSameGenre(string genre)
            => new HashSet<Song>(
                from song in SongContext.Songs
                where song.IsDeleted == false && song.Genre== genre
                orderby song.Id
                select song);

        /// <summary>
        /// Returns a list with all the not deleted songs from the same year.
        /// </summary>
        /// <param name="year">The name of the year.</param>
        /// <returns>HashSet object with the list.</returns>
        public HashSet<Song> SongsOfSameYear(int year)
            => new HashSet<Song>(
                from song in SongContext.Songs
                where song.IsDeleted == false && song.Year == year
                orderby song.Id
                select song);

        /// <summary>
        /// Returns a list with all the not deleted songs if the same genre.
        /// </summary>
        /// <param name="genre">The name of the genre.</param>
        /// <returns>HashSet object with the list.</returns>
        public HashSet<Song> SongsFromSameGenre(string genre)
            => new HashSet<Song>(
                from song in SongContext.Songs
                where song.IsDeleted == false && song.Genre==genre
                orderby song.Id
                select song);

        /// <summary>
        /// Returns a list with all the not 
        /// deleted songs if the same year.
        /// </summary>
        /// <param name="year">The name of the year.</param>
        /// <returns>HashSet object with the list.</returns>
        public object SongsFromSameYear(int year)
            => new HashSet<Song>(
                from song in SongContext.Songs
                where song.IsDeleted == false 
                    && song.Year == year
                orderby song.Id
                select song);
    }
}
