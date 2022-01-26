using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRManager.Models.EntityViews
{
    public class EmployeeBankInfo
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        [Display(Name = "Bank Name")]
        [Required]
        public string BankName { get; set; }
        [Display(Name = "Name As Per Bank Account")]
        [Required]
        public string NameAsPerBankAccount { get; set; }
        [Display(Name = "Account Number")]
        [Required]
        public string AccountNumber { get; set; }
        [Display(Name = "Branch Name")]
        [Required]
        public string BranchName { get; set; }
        [Display(Name = "IFSC Code")]
        [Required]
        public string IFSCCode { get; set; }

    }
}
