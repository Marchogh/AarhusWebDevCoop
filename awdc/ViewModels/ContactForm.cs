using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace awdc.ViewModels
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter a Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a Email")]
        [Display(Name = "Email")]
        [RegularExpression(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$",
            ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please leave a message")]
        public string Message { get; set; }
    }
}