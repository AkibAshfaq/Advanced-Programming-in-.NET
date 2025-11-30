using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace ZeroHunger.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class AgeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true; // [Required] should handle null

            int age;

            if (!int.TryParse(value.ToString(), out age))
                return false;

            // Correct logic: age must be between 18 and 65
            if (age < 18 || age > 65)
                return false;

            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(CultureInfo.CurrentCulture,
                "{0} must be between 18 and 65.", name);
        }
    }
}
