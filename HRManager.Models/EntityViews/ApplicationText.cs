using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class ApplicationText :EntityBase
    {
        public byte Id { get; set; }
        public string ConfidentialityAgreement { get; set; }
        public string ServiceLevelAgreement { get; set; }
        public string BGVAcknowlwdgement { get; set; }
        public byte OrganizationId { get; set; }
        
    }
}
