using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Model.Validation
{
    //Attribute Validation
    public class Shirt_EnsureCorrectSizingAttribute: ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;

            if (shirt != null && !string.IsNullOrEmpty(shirt.Gender))
            {
                if (shirt.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && shirt.Size < 8)
                {
                    return new ValidationResult("For men's shirt. The size has to be greated or equal to 8.");
                } else if (shirt.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && shirt.Size < 6)
                {
                    return new ValidationResult("For women's shirt. The size has to be greated or equal to 6.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
