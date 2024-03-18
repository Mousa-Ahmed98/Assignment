using System.ComponentModel.DataAnnotations;

namespace Assignment.Models.CustomAttributes
{
    public class UniqueAttribute : ValidationAttribute
    {
        ITIContext ITIContext = new ITIContext();
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if(ITIContext.Courses.FirstOrDefault(c => c.Name == value.ToString()) == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Name must be unique.");
        }
    }
}
