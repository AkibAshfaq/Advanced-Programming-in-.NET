using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidationTask.Models
{
    public class LogIn
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z.]+$", ErrorMessage = "Only alphabate")]
        public string Name { get; set; }
        
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Only alphabate & number")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "Pattern mismatch xx-xxxxx-x")]
        public string Id { get; set; }

        [Required]
        public string Dob { get; set; }


        [Required]
        [RegularExpression(@"^{\d{2}-\d{5}-\d{1}}+@student./aiub./edu$", ErrorMessage = "Email Must contain your Id")]
        public string Email { get; set; }
    }
}