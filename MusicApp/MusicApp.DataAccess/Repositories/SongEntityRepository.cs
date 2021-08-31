using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicApp.DataAccess.Repositories
{
    public class SongEntityRepository : IRepository<Song>
    {
        public List<Song> GetAll()
        {
            return StaticDb.Songs.ToList();
        }

        public Song GetById(int id)
        {
            return StaticDb.Songs.FirstOrDefault(x=> x.Id.Equals(id));
        }

        public int Insert(Song entity)
        {
            Song lastSong = StaticDb.Songs.FirstOrDefault();
            if(lastSong == null)
            {
                entity.Id = 1;
            }
            else
            {
                entity.Id = lastSong.Id + 1;
            }
            StaticDb.Songs.Add(entity);
            return entity.Id;
        }

        public void Update(Song entity)
        {
            Song song = StaticDb.Songs.FirstOrDefault(x => x.Id.Equals(entity.Id));
            if(song != null)
            {
                song.Name = entity.Name;
                song.Artist = entity.Artist;
                song.Album = entity.Album;
                song.CreatedOn = entity.CreatedOn;
            }
        }
        public void DeleteById(int id)
        {
            Song song = StaticDb.Songs.FirstOrDefault(x => x.Id.Equals(id));
            if(song != null)
            {
                StaticDb.Songs.Remove(song);
            }
        }

    }
}

