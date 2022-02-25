using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class EntityBase
    {
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy { get; set; }

    }
}
