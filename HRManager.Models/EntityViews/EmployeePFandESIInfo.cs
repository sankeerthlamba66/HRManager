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
        [Display(Name = "UAN")]
        [Required]
        public string? UAN { get; set; }
        [Display(Name = "ESIN")]
        [Required]
        public string? ESIN { get; set; }
    }
}
