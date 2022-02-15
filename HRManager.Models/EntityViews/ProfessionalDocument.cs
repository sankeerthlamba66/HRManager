using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class ProfessionalDocument:EmployeeProfessionalInfo
    {
        [Display(Name = "Offer Letter Path")]
        [Required]
        public string OfferLetterPath { get; set; }
        [Display(Name = "Relieving Letter Path")]
        [Required]
        public string RelievingLetterPath { get; set; }
        [Display(Name = "Experience Letter Path")]
        [Required]
        public string ExperienceLetterPath { get; set; }
        [Display(Name = "Pay Slip 1")]
        [Required]
        public string PaySlip1 { get; set; }
        [Display(Name = "Pay Slip 2")]
        [Required]
        public string PaySlip2 { get; set; }
        [Display(Name = "Pay Slip 3")]
        [Required]
        public string PaySlip3 { get; set; }
        
    }
}
