namespace DatingApp.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Username { get; internal set; }
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

    }
}
