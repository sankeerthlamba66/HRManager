using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeePermanentAddress
    {
        [Display(Name = "Address Line 1")]
        public string? AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }
        [Display(Name = "Address Line 3")]
        public string? AddressLine3 { get; set; }
        public string? City { get; set; }
        public States State { get; set; }
        public int Pincode { get; set; }
    }
}
