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
         
        }
        public List<EmployeeTableSummary> EmployeeData { get; set; }
        public bool AddVerificationLinks { get; set; }

        
    }

}
