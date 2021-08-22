using MusicApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public long Phone { get; set; }
        public UserAccount Account { get; set; }
        public Account Price { get; set; }

    }
}
