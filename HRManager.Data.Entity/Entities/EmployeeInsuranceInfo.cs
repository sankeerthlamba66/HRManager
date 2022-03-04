using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models;

namespace HRManager.Data.Entity.Entities
{
    public class EmployeeInsuranceInfo : EntityBase
    {
        public int Id { get; set; }

        public string? NameAsPerAadhar { get; set; }
        public string? Relationship { get; set; }
        public string? Gender { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? DateOfBirthAsPerAadhar { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
