using Gamora.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gamora.Models;

namespace Gamora.Repositories
{
    public class SongRepository
    {
        public SongContext SongContext { get; set; }

        public SongRepository(SongContext songContext)
        {
            SongContext = songContext;
        }

        public void Add(Song song)
        {
            SongContext.Add(song);
            SongContext.SaveChanges();
        }

        internal void ChangeRating(int id, int newRating)
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

        public IQueryable<Song> FavouriteSongs(int numberOfSongs)
            => SongContext
                .Songs
                .OrderBy(s => s.Rating)
                .Reverse()
                .Take(numberOfSongs);

        internal IQueryable<Song> SongsFromSameAuthor(string author)
            => SongContext
                .Songs
                .Where(s => s.Author.Equals(author));
    }
}
