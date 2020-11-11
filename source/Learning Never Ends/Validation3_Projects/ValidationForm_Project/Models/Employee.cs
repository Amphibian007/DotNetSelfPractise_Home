using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationForm_Project.Models
{
    public class Employee
    {
        [Required (ErrorMessage ="This field is required")]
        [MinLength(2)]
        public string Name { get; set; }
        [Required (ErrorMessage ="This field is also required")]
        public string Gender { get; set; }

        [Required (ErrorMessage ="Age is require")] 
        [Range(10,maximum:15, ErrorMessage ="Enter age between in 10 to 15")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Email is require")]
        [EmailAddress(ErrorMessage ="Email is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$"
        ,ErrorMessage = "Minimum eight characters, at least one uppercase , one lowercase and one number")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Confirm password is a must")]
        [Compare("Password")]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Channel Url is must")]
        [Url(ErrorMessage ="Url is not correct")]
        public string ChannelUrl { get; set; }
    }
}
