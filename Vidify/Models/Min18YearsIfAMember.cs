using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidify.Models 
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("A Date of Birth is required");

            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;

            return (age >= 18) ? 
                ValidationResult.Success : new ValidationResult("Customer must be 18 years or older for this membership");
        }
    }
}