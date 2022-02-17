using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;

namespace HRManager.Models.ViewModels
{
    public class AllEmployeeTable
    {
        public AllEmployeeTable()
        {
            this.EmployeeData = new List<EmployeeTableSummary>();
        }
        public List<EmployeeTableSummary> EmployeeData { get; set; }
        public bool AddVerificationLinks { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }

}
