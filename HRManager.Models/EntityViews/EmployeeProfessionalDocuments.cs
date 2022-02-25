using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeeProfessionalDocuments:EmployeeProfessionalInfo
    {
        [Display(Name = "Offer Letter")]
        public string? OfferLetterPath { get; set; }
        [Display(Name = "Relieving Letter")]
        public string? RelievingLetterPath { get; set; }
        [Display(Name = "Experience Letter")]
        public string? ExperienceLetterPath { get; set; }
        [Display(Name = "Pay Slip 1")]
        public string? PaySlip1 { get; set; }
        [Display(Name = "Pay Slip 2")]
        public string? PaySlip2 { get; set; }
        [Display(Name = "Pay Slip 3")]
        public string? PaySlip3 { get; set; }
    }
}
