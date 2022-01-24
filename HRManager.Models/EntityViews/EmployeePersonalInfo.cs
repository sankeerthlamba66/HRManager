using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeePersonalInfo
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNumber { get; set; }
        public string PersonalEmailId { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string RelationshipWithContact { get; set; }
        public string PanCardNumber { get; set; }
        public string NameAsPerAadhar { get; set; }
        public string AadharCardNumber { get; set; }
        public string FathersNameAsPerAadhar { get; set; }
        public string FathersMobileNumber { get; set; }
        public string MothersNameAsPerAadhar { get; set; }
        public ReferalSource HowWereYouReferredToUs { get; set; }
    }
}
