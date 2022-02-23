using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeeProfessionalIForms:EmployeeProfessionalInfo
    {
        [Display(Name = "Offer Letter")]
        public IFormFile OfferLetter { get; set; }
        [Display(Name = "Relieving Letter")]
        public IFormFile RelievingLetter { get; set; }
        [Display(Name = "Experience Letter")]
        public IFormFile ExperienceLetter { get; set; }
        [Display(Name = "Pay Slip 1")]
        public IFormFile PaySlip1 { get; set; }
        [Display(Name = "Pay Slip 2")]
        public IFormFile PaySlip2 { get; set; }
        [Display(Name = "Pay Slip 3")]
        public IFormFile PaySlip3 { get; set; }
    }
}
