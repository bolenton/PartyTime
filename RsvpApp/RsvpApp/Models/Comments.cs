using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RsvpApp.Models
{
    public class Comments
    {
        public int CommentId { get; set; }

        public bool Paid { get; set; }
          
        [Required]
        public string Name { get; set; }
        [Required]
        public string Message { get; set; }

        public string Age { get; set; }
    }
}