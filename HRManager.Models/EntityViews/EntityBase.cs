using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EntityBase
    {
        public string? CreatedBy { get; set; }

        public string? UpdatedBy { get; set; }
    }
}
