using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.Views
{
    public class EmployeeTableSummary
    {
        [Display(Name = "Employee Id")]
        public string EmployeeId { get; set; }
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        public string? EmployeeName { get; set; }
        [Display(Name = "Mobile Number")]
        public string? MobileNumber { get; set; }

        [Display(Name = "Personal EmailId")]
        public string? PersonalEmailId { get; set; }

        [Display(Name ="UserID")]
        public int UserId { get; set; }

        [Display(Name = "PAN Card")]
        public string? PanCard { get; set; }
    }
}
