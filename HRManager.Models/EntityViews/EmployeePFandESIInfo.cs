using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.EntityViews
{
    public class EmployeePFandESIInfo
    {
        public int? Id { get; set; }
        public int UserId { get; set; }
        public string UAN { get; set; }
        public string ESIN { get; set; }
    }
}
