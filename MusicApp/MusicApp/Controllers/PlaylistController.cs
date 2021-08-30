using Microsoft.AspNetCore.Mvc;
using MusicApp.Domain.Models;
using MusicApp.Models;
using MusicApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Controllers
{
    public class PlaylistController : Controller
    {
        private IPlaylistService _playlistService;
        public PlaylistController(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }
        public IActionResult Index(Song entity)
        {
            List<Playlist> allSongs = _playlistService.GetAllSongs(entity);
            return View(allSongs);
        }
        [HttpPost]
        public IActionResult Create(int id)
        {
            Playlist playlist = _playlistService.MakeNewPlaylist(id);
            PlaylistViewModel newPlaylist = new PlaylistViewModel()
            {
                Id = playlist.Id,
                Name = playlist.Name,
                Song = playlist.Song,
                Date = playlist.CreatedOn
            };
            return View(newPlaylist);
        }
        [HttpPost]
        public IActionResult Edit(Song song)
        {
            _playlistService.AddNewSong(song);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
           _playlistService.GetLastSong();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSong(int id)
        {
            _playlistService.DeleteSongById(id);
            return RedirectToAction("Idex");
        }
        public IActionResult DeletePlaylist(int id)
        {
            _playlistService.DeletePlaylistById(id);
            return RedirectToAction("Index");
        }
    }
}
