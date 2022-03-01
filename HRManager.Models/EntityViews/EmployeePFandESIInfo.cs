using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRManager.Models.EntityViews
{
    public class EmployeePFandESIInfo : EntityBase
    {
        public int? Id { get; set; }
        public int UserId { get; set; }

        [Required]
        [Display(Name = "UAN")]
        [StringLength(12,MinimumLength =12)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Use digits only please")]
        public string? UAN { get; set; }

        [Required]
        [Display(Name = "ESIN")]
        public string? ESIN { get; set; }
    }
}
