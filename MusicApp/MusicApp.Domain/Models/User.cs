namespace MusicApp.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }
    }
}
