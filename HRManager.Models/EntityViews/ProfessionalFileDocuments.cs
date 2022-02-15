using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class ProfessionalFileDocuments:EmployeeProfessionalInfo
    {
        public IFormFile RelievingLetterPath { get; set; }
        [Display(Name = "Experience Letter Path")]
        [Required]
        public IFormFile ExperienceLetterPath { get; set; }
        [Display(Name = "Pay Slip 1")]
        [Required]
        public IFormFile PaySlip1 { get; set; }
        [Display(Name = "Pay Slip 2")]
        [Required]
        public IFormFile PaySlip2 { get; set; }
        [Display(Name = "Pay Slip 3")]
        [Required]
        public IFormFile PaySlip3 { get; set; }
    }
}
