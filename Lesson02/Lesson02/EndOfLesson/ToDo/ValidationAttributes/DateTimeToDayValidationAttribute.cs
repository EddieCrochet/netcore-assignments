using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.ValidationAttributes
{
    public class DateTimeToDayValidationAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dateTime = value as DateTime?;
            if (!dateTime.HasValue && value != null)
                throw new ArgumentException("this attribute can only be used with date time types");
            if (!dateTime.HasValue)
                return ValidationResult.Success;
            if (dateTime.Value > DateTime.Now)
                return ValidationResult.Success;

            return new ValidationResult("DateTime should be less than today");
        }
    }
}
