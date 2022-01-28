using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRManager.Models.EntityViews
{
    public class EmployeeInsuranceInfo
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        [Display(Name = "Name As Per Aadhar")]
        [Required]
        public string NameAsPerAadhar { get; set; }
        [Display(Name = "Relationship")]
        [Required]
        public string Relationship { get; set; }
        [Display(Name = "Gender")]
        [Required]
        public Gender Gender { get; set; }
        [Display(Name = "Date Of Birth As Per Aadhar")]
        [Required]
        public DateOnly DateOfBirthAsPerAadhar { get; set; }
        
    }
}
