using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicApp.DataAccess.Repositories
{
    public class PlaylistEntityRepository : IRepository<Playlist>
    {
        public List<Playlist> GetAll()
        {
            return StaticDb.Playlists.ToList();
        }

        public Playlist GetById(int id)
        {
            return StaticDb.Playlists.FirstOrDefault(x => x.Id.Equals(id));
        }

        public int Insert(Playlist entity)
        {
            Playlist newPlaylist = StaticDb.Playlists.FirstOrDefault();
            if (newPlaylist == null)
            {
                entity.Id = 1;
            }
            else
            {
                entity.Id = newPlaylist.Id + 1;
            }
            return entity.Id;
        }

        public int Insert(Song entity)
        {
            Song newSong = StaticDb.Songs.FirstOrDefault();
            if (newSong == null)
            {
                entity.Id = 1;
            }
            else
            {
                entity.Id = newSong.Id + 1;
            }
            return entity.Id;
        }

        public void Update(Playlist entity)
        {
            Playlist playlist = StaticDb.Playlists.FirstOrDefault(x => x.Id.Equals(entity.Id));
            if(playlist != null)
            {
                playlist.Name = entity.Name;
                playlist.Song = entity.Song;
                playlist.CreatedOn = entity.CreatedOn;
            }
        }
        public void DeleteById(int id)
        {
            Playlist playlist = StaticDb.Playlists.FirstOrDefault(x => x.Id.Equals(id));
            if(playlist != null)
            {
                StaticDb.Playlists.Remove(playlist);
            }
        }
    }
}
