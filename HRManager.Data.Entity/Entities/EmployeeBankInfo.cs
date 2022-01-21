using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class EmployeeBankInfo : EntityBase
    {
        public int Id { get; set; }

        public string BankName { get; set; }
        public string NameAsPerBankAccount { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
