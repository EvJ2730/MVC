using MusicApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Domain.Models
{
    public class Account
    {
        public UserAccount Standard { get; set; }
        public UserAccount Premium { get; set; }
        public UserAccount Medium { get; set; }
        public UserAccount Family { get; set; }
    }
}
