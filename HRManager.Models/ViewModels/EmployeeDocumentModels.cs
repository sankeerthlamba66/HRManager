using HRManager.Models.EntityViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.ViewModels
{
    public class EmployeeDocumentModels
    {
        public EmployeeDocumentModels()
        {
            this.employeeFileDocuments = new EmployeeFileDocument();
            this.employeeDocuments = new EmployeeDocument();
        }
        public EmployeeFileDocument employeeFileDocuments { get; set; }
        
        public EmployeeDocument employeeDocuments { get; set; }
    }
}
