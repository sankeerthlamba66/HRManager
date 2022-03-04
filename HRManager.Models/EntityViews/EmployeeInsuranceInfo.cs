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
        
        [Required]
        [Display(Name = "Name As Per Aadhar")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? NameAsPerAadhar { get; set; }
        
        [Required]
        [Display(Name = "Relationship")]
        public string? Relationship { get; set; }
        
        [Required]
        [Display(Name = "Gender")]
        public string? Gender { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Display(Name = "Date Of Birth As Per Aadhar")]
        public DateTime? DateOfBirthAsPerAadhar { get; set; }
        
    }
}
