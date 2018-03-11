using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace customVlidatorProject.Models
{
    public class EndDateValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (Models.DateValidationClass)validationContext.ObjectInstance;
            DateTime endDate = Convert.ToDateTime(value);
            DateTime startDate = Convert.ToDateTime(model.StartDate);

            if (startDate > endDate)
            {
                return new ValidationResult
                    ("Last Date can not be less than Join date.");
            }
            else if (endDate > DateTime.Now)
            {
                return new ValidationResult
                    ("Last  Date can not be greater than current date.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}