using MusicApp.Domain.Enums;
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
                Date = new DateTime(11/30/2018)
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
                Account = UserAccount.Premium,
                
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
    }
}
