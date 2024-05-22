using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Model.Validation
{
    public class Shirt_EnsureGenderAttribute : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;

            if (shirt != null && !string.IsNullOrEmpty(shirt.Gender))
            {
                if(!shirt.Gender.Equals("male", StringComparison.OrdinalIgnoreCase) && !shirt.Gender.Equals("female", StringComparison.OrdinalIgnoreCase))
                {
                    return new ValidationResult("For gender, ensure you insert either male or female.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
