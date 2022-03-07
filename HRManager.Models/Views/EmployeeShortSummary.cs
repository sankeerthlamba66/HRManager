using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.Views
{
    public class EmployeeShortSummary
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public int UserID { get; set; }

        //Any other
    }
}
