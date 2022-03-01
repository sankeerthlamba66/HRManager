using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRManager.Models.EntityViews
{
    public class EmployeeBankInfo:EntityBase
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        
        [Required]
        [Display(Name = "Bank Name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? BankName { get; set; }
        
        [Required]
        [Display(Name = "Name As Per Bank Account")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? NameAsPerBankAccount { get; set; }
        
        [Required]
        [Display(Name = "Account Number")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Use digits only please")]
        public string? AccountNumber { get; set; }
        
        [Required]
        [Display(Name = "Branch Name")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Use letters only please")]
        public string? BranchName { get; set; }
        
        [Required]
        [Display(Name = "IFSC Code")]
        [RegularExpression(@"^[A-Z0-9]*$", ErrorMessage = "Use Block Letters and Numerics only please")]
        public string? IFSCCode { get; set; }

    }
}
