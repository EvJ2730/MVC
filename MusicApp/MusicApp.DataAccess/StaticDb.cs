
using MusicApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.DataAccess
{
    public static class StaticDb
    {
        public static List<Song> Songs = new List<Song>()
        {
            new Song
            {
                Id = 1,
                Name = "Venus Flytrap",
                Artist = "Feng Suave",
                Album = "Venus Flytrap",
                Duration = 0.00m,
                CreatedOn = new DateTime(11/30/2018)
            },

            new Song
            {
                Id = 2,
                Name = "Bad Habits",
                Artist = "Ed Sheeran",
                Album = "Bad HAbits: The Remixes",
                Duration = 0.00m,
                CreatedOn = new DateTime(06/25/2021)
            },

            new Song
            {
                Id = 3,
                Name = "A Bomb",
                Artist = "Babalos",
                Album = "Unknown",
                Duration = 0.00m,
                CreatedOn = new DateTime(02/11/2018)
            },

            new Song
            {
                Id = 4,
                Name = "Vapo VApo",
                Artist = "Mandragora",
                Album = "Vapo Vapo",
                Duration = 0.00m,
                CreatedOn = new DateTime(06/19/2020)
            },

            new Song
            {
                Id = 5,
                Name = "Snow Crystal",
                Artist = "Babalos",
                Album = "Unknown",
                Duration = 0.00m,
                CreatedOn = new DateTime(02/11/2018)
            },

            new Song
            {
                Id = 6,
                Name = "Codeine",
                Artist = "Mandragora",
                Album = "Disc 1",
                Duration = 0.00m,
                CreatedOn = new DateTime(08/03/2018)
            },

            new Song
            {
                Id = 7,
                Name = "Galactic Symphony",
                Artist = "Mandragora",
                Album = "Galactic Symphony",
                Duration = 0.00m,
                CreatedOn = new DateTime(12/03/2018)
            },

            new Song
            {
                Id = 8,
                Name = "Shum",
                Artist = "Go_A",
                Album = "Shum",
                Duration = 0.00m,
                CreatedOn = new DateTime(03/09/2021)
            },

            new Song
            {
                Id = 9,
                Name = "Frka",
                Artist = "Nipplepeople",
                Album = "SINGLES",
                Duration = 0.00m,
                CreatedOn = new DateTime(07/19/2015)
            },

            new Song
            {
                Id = 10,
                Name = "Buč Kesidi",
                Artist = "Nema ljubavi u klubu",
                Album = "Nema Ljubavi U Klubu",
                Duration = 0.00m,
                CreatedOn = new DateTime(11/20/2018)
            }


        };
        public static List<User> Users = new List<User>()
        {
            new User
            {
                Id = 1,
                FirstName = "Eva",
                LastName = "Janeva",
                Username = "EvJ2730",
                Mail = "janeva.aerodrom@gmail.com",
                Address = "Damaska 11A",
                Phone = 071858000,
                Type = new Account(),
                Price = new Account(),
            }
        };

        public static List<Account> Price = new List<Account>()
        {
            new Account
            {
                Standard = "free",
                Student = "5$",
                Premium = "10$",
                Family = "18$"
            }
        };

        public static List<Playlist> Playlists = new List<Playlist>()
        {
            new Playlist
            {
                Id = 1,
                Name = "Techno",
                Song = new List<Song>()/* -ova e od lista vo Playlist.cs | vo listata od Playlists treba da ima ushte edna lista od Songs | go najdov reshenieto ama ke go ostavam komentarov za more self esteem :) */
                {
                    new Song
                    {
                        Id = 3,
                        Name = "A Bomb",
                        Artist = "Babalos",
                        Album = "Unknown",
                        Duration = 0.00m,
                        CreatedOn = new DateTime(02/11/2018)
                    },

                    new Song
                    {
                        Id = 4,
                        Name = "Vapo VApo",
                        Artist = "Mandragora",
                        Album = "Vapo Vapo",
                        Duration = 0.00m,
                        CreatedOn = new DateTime(06/19/2020)
                    },

                    new Song
                    {
                        Id = 5,
                        Name = "Snow Crystal",
                        Artist = "Babalos",
                        Album = "Unknown",
                        CreatedOn = new DateTime(02/11/2018)
                    },

                    new Song
                    {
                        Id = 6,
                        Name = "Codeine",
                        Artist = "Mandragora",
                        Album = "Disc 1",
                        Duration = 0.00m,
                        CreatedOn = new DateTime(08/03/2018)
                    },

                    new Song
                    {
                        Id = 7,
                        Name = "Galactic Symphony",
                        Artist = "Mandragora",
                        Album = "Galactic Symphony",
                        Duration = 0.00m,
                        CreatedOn = new DateTime(12/03/2018)
                    },

                    new Song
                    {
                        Id = 8,
                        Name = "Shum",
                        Artist = "Go_A",
                        Album = "Shum",
                        Duration = 0.00m,
                        CreatedOn = new DateTime(03/09/2021)
                    }
                },
                CreatedOn = new DateTime()
            }
        };
    }
}
