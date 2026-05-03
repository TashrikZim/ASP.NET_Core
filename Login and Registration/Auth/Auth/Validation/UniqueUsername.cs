using AspNetCoreGeneratedDocument;
using System.ComponentModel.DataAnnotations;
using Auth.EF; 

namespace Auth.Validation
{
    public class UniqueUsername : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var db = (AuthRegistrationContext)validationContext.GetService(typeof(AuthRegistrationContext));
            if (value != null)
            {
                var u = (from user in db.Users
                         where user.Username.Equals(value.ToString())
                         select user).SingleOrDefault();

                if (u == null)
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult("UserName Exists");
            }
            return new ValidationResult("Username required");
        }
    }
}
