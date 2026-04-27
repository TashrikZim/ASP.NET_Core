using System.ComponentModel.DataAnnotations;

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

        public string Username { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
