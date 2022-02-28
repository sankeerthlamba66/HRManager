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
        [RegularExpression(@"^[a-zA-Z]", ErrorMessage = "Use letters only please")]
        public string? UserName { get; set; }
        public string? Password { get; set; }
        
        [Required]
        [Display(Name = "Roles")]
        [RegularExpression(@"^[a-zA-Z]", ErrorMessage = "Use letters only please")]
        public string? Roles { get; set; }

        [Required]
        [Display(Name = "Organization Name")]
        public OrganizationName OrganizationName { get; set; }

        [Required]
        [Display(Name = "Organization ID")]
        public Byte OrganizationId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "User Email Id")]
        public string? UserMailId { get; set; }
    }
}
