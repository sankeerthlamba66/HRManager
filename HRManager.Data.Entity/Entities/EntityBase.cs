using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class EntityBase
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
