using HRManager.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.ViewModels
{
    public class FileNameFileValue
    {
        public FileNameFileValue()
        {
            this.employeeInfoValidations = new EmployeeInfoValidation();
        }
        public EmployeeInfoValidation employeeInfoValidations { get; set; }
    }
}
