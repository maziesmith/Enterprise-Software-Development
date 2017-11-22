using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ePhoneBook.Models
{
    public class PhoneBookModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength =6)]

        public String FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public String MiddleName { get; set; }
    }
}