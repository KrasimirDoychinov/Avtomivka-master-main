using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Avtomivka.A.Attributes
{
    public class ReservationDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = value as DateTime?;

            if (date.HasValue)
            {
                if (date.Value.Date < DateTime.Now.Date)
                {
                    return new ValidationResult("Reservation date cannot be before current date");
                }
            }
            


            return ValidationResult.Success;
        }
    }
}
