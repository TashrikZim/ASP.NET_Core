using System.ComponentModel.DataAnnotations;
using Auth.Validation;

namespace Auth.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Requireddd")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [UniqueUsername]

        public string Username { get; set; }
        [Required]
        [PasswordMatch]
        public string ConfirmPassword { get; set; }

    }
}
