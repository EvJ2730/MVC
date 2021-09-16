using MusicApp.Domain.Models;
using System;

namespace MusicApp.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
