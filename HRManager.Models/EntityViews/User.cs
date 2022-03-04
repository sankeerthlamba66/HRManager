using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class User :EntityBase
    {
        public int? Id { get; set; }
        
        [Required]
        [Display(Name = "User Name")]
        [RegularExpression(@"^[a-zA-Z \s]*$", ErrorMessage = "Use letters only please")]
        public string? UserName { get; set; }

        public string? Password { get; set; }
        
        [Required]
        [Display(Name = "Roles")]
        public string? Roles { get; set; }

        [Required]
        [Display(Name = "Entity")]
        public string? OrganizationName { get; set; }

        [Required]
        [Display(Name = "Organization ID")]
        public Byte OrganizationId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "User Email Id")]
        public string? UserMailId { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        [Display(Name = "Mobile Number")]
        public string? MobileNumber { get; set; }

        public IFormFile? File { get; set; }
    }
}
