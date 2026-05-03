using Auth.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Auth.Validation
{
    public class PasswordMatch : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var obj = validationContext.ObjectInstance as RegisterDTO;
            if (obj != null && obj.Password.Equals(value.ToString()))
            {
               return ValidationResult.Success;
            }
            return new ValidationResult("Password and Confirm password Mismatched");
        }
    }
}
