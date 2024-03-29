﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models;
namespace HRManager.Data.Entity.Entities
{
    public class EmployeePersonalInfo : EntityBase
    {
        public int Id { get; set; }

        public string EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string? CurrentAddressLine1 { get; set; }
        public string? CurrentAddressLine2 { get; set; }
        public string? CurrentAddressLine3 { get; set; }
        public string? CurrentCity { get; set; }
        public States CurrentState { get; set; }
        public string? CurrentPinCode { get; set; }
        public string? PermanentAddressLine1 { get; set; }
        public string? PermanentAddressLine2 { get; set; }
        public string? PermanentAddressLine3 { get; set; }
        public string? PermanentCity { get; set; }
        public  States PermanentState { get; set; }
        public string? PermanentPincode { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
        public string? MobileNumber { get; set; }
        public string? PersonalEmailId { get; set; }
        public string? CurrentAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactNumber { get; set; }
        public EmergencyContactRelationship RelationshipWithContact { get; set; }
        public string? PanCardNumber { get; set; }
        public string? NameAsPerAadhar { get; set; }
        public string? AadharCardNumber { get; set; }
        public string? FathersNameAsPerAadhar { get; set; }
        public string? FathersMobileNumber { get; set; }
        public string? MothersNameAsPerAadhar { get; set; }
        //public ReferalSource HowWereYouReferredToUs { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
