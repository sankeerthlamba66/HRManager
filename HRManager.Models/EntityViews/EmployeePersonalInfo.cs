using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeePersonalInfo : EntityBase
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        public string EmployeeId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? FirstName { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        [Display(Name = "Middle Name")]
        public string? MiddleName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Required]
        [Display(Name = "Marital Status")]
        public string? MaritalStatus { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        [Display(Name = "Mobile Number")]
        public string? MobileNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Personal Email Id")]
        public string? PersonalEmailId { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string? CurrentAddressLine1 { get; set; }

        [Required]
        [Display(Name = "Address Line 2")]
        public string? CurrentAddressLine2 { get; set; }

        [Required]
        [Display(Name = "Address Line 3")]
        public string? CurrentAddressLine3 { get; set; }

        [Required]
        [Display(Name = "City")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? CurrentCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string? CurrentState { get; set; }

        [Required]
        [Display(Name = "Pincode")]
        //[RegularExpression(@"^([0-9]{6})*$", ErrorMessage = "Use digits only please")]
        public int? CurrentPinCode { get; set; }

        [Required]
        [Display(Name = "Adress Line 1")]
        public string? PermanentAddressLine1 { get; set; }

        [Required]
        [Display(Name = "Adress Line 2")]
        public string? PermanentAddressLine2 { get; set; }

        [Required]
        [Display(Name = "Address Line 3")]
        public string? PermanentAddressLine3 { get; set; }

        [Required]
        [Display(Name = "City")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? PermanentCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string? PermanentState { get; set; }

        [Required]
        [Display(Name = "Pincode")]
        //[RegularExpression(@"^[0-9]*$", ErrorMessage = "Use digits only please")]
        public int? PermanentPincode { get; set; }

        [Required]
        [Display(Name = "Blood Group")]
        public string? BloodGroup { get; set; }

        [Required]
        [Display(Name = "Emergency Contact Name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? EmergencyContactName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Emergency Contact Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string? EmergencyContactNumber { get; set; }

        [Required]
        [Display(Name = "Relationship With Contact")]
        public string? RelationshipWithContact { get; set; }

        [Required]
        [Display(Name = "Pan Card Number")]
        [StringLength(10,MinimumLength=10)]
        [RegularExpression(@"^[A-Z0-9]*$", ErrorMessage = "Use Block letters and digits only please")]
        public string? PanCardNumber { get; set; }

        [Required]
        [Display(Name = "Name As Per Aadhar")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? NameAsPerAadhar { get; set; }

        [Required]
        [Display(Name = "Aadhar Card Number")]
        [StringLength(12, MinimumLength = 12)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Use digits only please")]
        public string? AadharCardNumber { get; set; }

        [Required]
        [Display(Name = "Father's Name As per Aadhar")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? FathersNameAsPerAadhar { get; set; }

        [Phone]
        [Display(Name = "Father's Mobile Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string? FathersMobileNumber { get; set; }

        [Display(Name = "Mother's Name As per Aadhar")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? MothersNameAsPerAadhar { get; set; }

        //[Display(Name = "How Were You Referred To Us")]
        //public ReferalSource HowWereYouReferredToUs { get; set; }
    }
}
