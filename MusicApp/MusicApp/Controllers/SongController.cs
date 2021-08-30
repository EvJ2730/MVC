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
    public class SongController : Controller
    {
        private ISongService _songService;
        public SongController(ISongService songService)
        {
            _songService = songService;
        }
        public IActionResult Index()
        {
            List<Song> allSongs = _songService.GetAllSongs();
            List<SongViewModel> viewSongs = new List<SongViewModel>();
            foreach(Song song in allSongs)
            {
                SongViewModel mappedSong = new SongViewModel
                {
                    Id = song.Id,
                    Name = song.Name,
                    Artist = song.Artist,
                    Album = song.Album,
                    Duration = song.Duration,
                    Date = song.CreatedOn
                };
                viewSongs.Add(mappedSong);
            }
            return View();
        }
        public IActionResult Details(int id)
        {
            Song song = _songService.GetSongById(id);
            SongViewModel viewSong = new SongViewModel
            {
                Id = song.Id,
                Name = song.Name,
                Artist = song.Artist,
                Album = song.Album,
                Duration = song.Duration,
                Date = song.CreatedOn
            };
            return View(viewSong);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Song song)
        {
            _songService.AddSong(song);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Song song = _songService.GetSongById(id);
            return View(song);

        }
        [HttpPost]
        public IActionResult Edit(Song song)
        {
            _songService.UpdateSong(song);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Song song = _songService.GetSongById(id);
            SongViewModel deleteSong = new SongViewModel
            {
                Id = song.Id,
                Name = song.Name,
                Artist = song.Artist,
                Album = song.Album,
                Duration = song.Duration,
                Date = song.CreatedOn
            };
            return View(deleteSong);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _songService.DeleteSongById(id);
            return RedirectToAction("Index");
        }
    }
}
