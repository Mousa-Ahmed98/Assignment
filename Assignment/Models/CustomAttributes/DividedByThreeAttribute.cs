using System.ComponentModel.DataAnnotations;

namespace Assignment.Models.CustomAttributes
{
    public class DividedByThreeAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if(int.Parse(value.ToString()) % 3 == 0)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Hours must be dividable by 3.");
        }
    }
}
