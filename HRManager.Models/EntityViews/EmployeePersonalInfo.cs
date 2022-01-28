using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeePersonalInfo
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        [Required]
        public string MiddleName { get; set; }
        [Display(Name ="Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Gender")]
        [Required]
        public Gender Gender { get; set; }
        [Display(Name = "Date Of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Middle Number")]
        [Required]
        public string MobileNumber { get; set; }
        [Display(Name = "Personal Email Id")]
        [Required]
        public string PersonalEmailId { get; set; }
        [Display(Name = "Current Address")]
        [Required]
        public string CurrentAddress { get; set; }
        [Display(Name = "Permanent Address")]
        [Required]
        public string PermanentAddress { get; set; }
        [Display(Name = "Blood Group")]
        [Required]
        public BloodGroup BloodGroup { get; set; }
        [Display(Name = "Emergency Contact Name")]
        [Required]
        public string EmergencyContactName { get; set; }
        [Display(Name = "Emergency Contact Number")]
        [Required]
        public string EmergencyContactNumber { get; set; }
        [Display(Name = "Relationship With Contact")]
        [Required]
        public string RelationshipWithContact { get; set; }
        [Display(Name = "Pan Card Number")]
        [Required]
        public string PanCardNumber { get; set; }
        [Display(Name = "Name As Per Aadhar")]
        [Required]
        public string NameAsPerAadhar { get; set; }
        [Display(Name = "Aadhar Card Number")]
        [Required]
        public string AadharCardNumber { get; set; }
        [Display(Name = "Father's Name As per Aadhar")]
        [Required]
        public string FathersNameAsPerAadhar { get; set; }
        [Display(Name = "Father's Mobile Number")]
        [Required]
        public string FathersMobileNumber { get; set; }
        [Display(Name = "Mother's Name As per Aadhar")]
        [Required]
        public string MothersNameAsPerAadhar { get; set; }
        [Display(Name = "How Were You Referred To Us")]
        [Required]
        public ReferalSource HowWereYouReferredToUs { get; set; }
    }
}
