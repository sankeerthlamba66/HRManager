using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRManager.Models.EntityViews
{
    public class EmployeeProfessionalInfo
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        [Display(Name = "Organization Name")]
        [Required]
        public string OrganizationName { get; set; }
        [Display(Name = "Is This Your Last Employment")]
        [Required]
        public bool IsThisYourLastEmployment { get; set; }
        [Display(Name = "Last Designation")]
        [Required]
        public string LastDesignation { get; set; }
        [Display(Name = "Start Date")]
        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "CTC")]
        [Required]
        public int CTC { get; set; }
        [Display(Name = "Reporting Manager Name")]
        [Required]
        public string ReportingManagerName { get; set; }
        [Display(Name = "Reporting Manager Email Id")]
        [Required]
        public string ReportingManagerEmailId { get; set; }
        [Display(Name = "HR Name")]
        [Required]
        public string HRName { get; set; }
        [Display(Name = "HR Email Id")]
        [Required]
        public string HREmailId { get; set; }
        [Display(Name = "Offer Letter Path")]
        [Required]
        public string OfferLetterPath { get; set; }
        [Display(Name = "Relieving Letter Path")]
        [Required]
        public string RelievingLetterPath { get; set; }
        [Display(Name = "Experience Letter Path")]
        [Required]
        public string ExperienceLetterPath { get; set; }
        [Display(Name = "Pay Slip !")]
        [Required]
        public string PaySlip1 { get; set; }
        [Display(Name = "Pay Slip 2")]
        [Required]
        public string PaySlip2 { get; set; }
        [Display(Name = "Pay Slip 3")]
        [Required]
        public string PaySlip3 { get; set; }
        [Display(Name = "Reference Email Id")]
        [Required]
        public string ReferenceEmailId { get; set; }
    }
}
