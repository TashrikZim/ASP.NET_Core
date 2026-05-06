using System.ComponentModel.DataAnnotations;

namespace Auth.DTOs
{
    public class loginDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
