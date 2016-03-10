using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyTime.Models
{
    public class GuestResponse
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        [Display(Name = "Will you Attend?")]
        public bool? WillAttend { get; set; }

        [Required(ErrorMessage = "Your must provide your first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your must provide your last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "You must provide a email address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "How many adults are coming with you>")]
        public int Adults { get; set; }

        [Required(ErrorMessage = "Please specify what day you plan on arriving")] // group of radio button will show
        public string Arrival { get; set; }

        [Required(ErrorMessage = "Please specify what day you plan on leaving")] // group of radio button will show
        public string Departure { get; set; }

        [Display(Name = "Any Other Info?")]
        public string Information { get; set; }      
    }
}