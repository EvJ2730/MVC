namespace MusicApp.Domain.Models
{
    public class Song : BaseEntity
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public decimal Duration { get; set; }
    }
}
