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
    }
}
