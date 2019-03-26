using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bugster.Models.util
{
    public class CustomDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            value = (DateTime) value;
            if (DateTime.Now.CompareTo(value) <= 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date must be not be in the past!");
            }
        }
    }
}
