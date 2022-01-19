using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class ApplicationText : EntityBase
    {
        public byte Id { get; set; }
        public string ConfidentialityAgreement { get; set; }
        public string ServiceLevelAgreement { get; set; }
        public string BGVAcknowlwdgement { get; set; }

        //Employeement Background Details Verification
        public string BGVEmailSubjectTemplate { get; set; }
        public string BGVEmailBodyTemplate { get; set; }

        //Personal Details Verification
        public string PDVEmailSubjectTemplate { get; set; }
        public string PDVEmailBodyTemplate { get; set; }
    }
}
