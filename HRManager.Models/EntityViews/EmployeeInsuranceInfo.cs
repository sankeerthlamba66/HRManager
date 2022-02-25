using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRManager.Models.EntityViews
{
    public class EmployeeInsuranceInfo : EntityBase
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        [Display(Name = "Name As Per Aadhar")]
        [Required]
        public string? NameAsPerAadhar { get; set; }
        [Display(Name = "Relationship")]
        [Required]
        public string? Relationship { get; set; }
        [Display(Name = "Gender")]
        [Required]
        public Gender Gender { get; set; }
        [Display(Name = "Date Of Birth As Per Aadhar")]
        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? DateOfBirthAsPerAadhar { get; set; }
        
    }
}
