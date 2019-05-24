using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public  string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Your password must be at least 4 digits long")]
        public string Password { get; set; }
        
    }
}