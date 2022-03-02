using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.EntityViews;
using Microsoft.AspNetCore.Http;

namespace HRManager.Models.ViewModels
{
    public class EmployeeProfessionalInfoModel
    {
        public EmployeeProfessionalInfoModel()
        {
            this.employeeProfessionalDocuments= new EmployeeProfessionalDocuments();
        }
        public EmployeeProfessionalDocuments employeeProfessionalDocuments { get; set; }

        [Display(Name = "Offer Letter")]
        [RegularExpression(@"(.png|.jpg|.jpeg|.pdf)$", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? OfferLetter { get; set; }

        [Display(Name = "Relieving Letter")]
        [RegularExpression(@"(.png|.jpg|.jpeg|.pdf)$", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? RelievingLetter { get; set; }

        [Display(Name = "Experience Letter")]
        [RegularExpression(@"(.png|.jpg|.jpeg|.pdf)$", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? ExperienceLetter { get; set; }

        [Display(Name = "Pay Slip 1")]
        [RegularExpression(@"(.png|.jpg|.jpeg|.pdf)$", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? PaySlip1 { get; set; }

        [Display(Name = "Pay Slip 2")]
        [RegularExpression(@"(.png|.jpg|.jpeg|.pdf)$", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? PaySlip2 { get; set; }

        [Display(Name = "Pay Slip 3")]
        [RegularExpression(@"(.png|.jpg|.jpeg|.pdf)$", ErrorMessage = "File format should be of type jpg,jpeg,png,pdf")]
        public IFormFile? PaySlip3 { get; set; }
    }
}
