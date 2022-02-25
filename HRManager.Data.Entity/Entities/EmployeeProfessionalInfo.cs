using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class EmployeeProfessionalInfo : EntityBase
    {
        public int Id { get; set; }

        public string? OrganizationName { get; set; }
        public bool IsThisYourLastEmployment { get; set; }
        public string? LastDesignation { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }
        public int CTC { get; set; }
        public string? ReportingManagerName { get; set; }
        public string? ReportingManagerEmailId { get; set; }
        public string? ReportingManagerMobileNumber { get; set; }
        public string? HRName { get; set; }
        public string? HREmailId { get; set; }
        public string? OfferLetterPath { get; set; }
        public string? RelievingLetterPath { get; set; }
        public string? ExperienceLetterPath { get; set; }
        public string? PaySlip1 { get; set; }
        public string? PaySlip2 { get; set; }
        public string? PaySlip3 { get; set; }
        //public string? ReferenceEmailId { get; set; }



        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
