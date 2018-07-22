using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RockPaperScissor.Models
{
    public class PlayerViewModel
    {
        [Required(ErrorMessage = "Please enter a Name")]
        [StringLength(20, ErrorMessage = "Please limit Name to 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an Email")]
        [EmailAddress(ErrorMessage ="Please enter a valid Email Address")]
        [StringLength(20, ErrorMessage = "Please limit Email to 20 characters")]
        public string Email { get; set; }

        [RegularExpression(@"^(\+44\s?7\d{3}|\(?07\d{3}\)?)\s?\d{3}\s?\d{3}$", ErrorMessage = "Please enter a valid UK Mobile Number")]
        public string Mobile { get; set; }
    }
}