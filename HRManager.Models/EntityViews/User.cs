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
        [Display(Name = "User Name")]
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Display(Name = "Roles")]
        [Required]
        public RoleType Roles { get; set; }
        [Display(Name = "Organization Id")]
        [Required]
        public byte OrganizationId { get; set; }
        [Display(Name = "User EmailId")]
        [Required]
        public string UserMailId { get; set; }
    }
}
