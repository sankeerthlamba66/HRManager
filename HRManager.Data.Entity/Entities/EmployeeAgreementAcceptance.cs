using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class EmployeeAgreementAcceptance:EntityBase
    {
        public int Id { get; set; }
        public bool ConfidentialityAgreementAccepted { get; set; }
        public bool ServiceLevelAgreement { get; set; }
        public bool BGVAcknowledgement { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
