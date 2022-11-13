using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PSI_MobileApp
{
    public class ProfileFilter
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name is too long.")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Password is too long.")]
        [RegularExpression (@"^[^\s\,]*$", ErrorMessage = "Password cannot contain whitespace characters.")]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password))]
        public string Confirm { get; set; }




    }
}
