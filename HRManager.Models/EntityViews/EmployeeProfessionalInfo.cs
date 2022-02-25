using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRManager.Models.EntityViews
{
    public class EmployeeProfessionalInfo : EntityBase
    {
        public int? Id { get; set; }
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Organization Name")]
        public string? OrganizationName { get; set; }

        [Required]
        [Display(Name = "Is This Your Previous Company")]
        public bool IsThisYourLastEmployment { get; set; }

        [Required]
        [Display(Name = "Last Designation")]
        public string? LastDesignation { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "CTC")]
        public int CTC { get; set; }

        [Required]
        [Display(Name = "Reporting Manager Name")]
        [RegularExpression(@"^[a-zA-Z]", ErrorMessage = "Use letters only please")]
        public string? ReportingManagerName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Reporting Manager Email Id")]
        public string? ReportingManagerEmailId { get; set; }

        [Phone]
        public string? ReportingManagerMobileNumber { get; set; }

        [Required]
        [Display(Name = "HR Name")]
        [RegularExpression(@"^[a-zA-Z]", ErrorMessage = "Use letters only please")]
        public string? HRName { get; set; }

        [Required]
        [Display(Name = "HR Email Id")]
        [EmailAddress]
        public string? HREmailId { get; set; }

        //[Display(Name = "Reference Email Id")]
        //[Required]
        //public string? ReferenceEmailId { get; set; }
    }
}
