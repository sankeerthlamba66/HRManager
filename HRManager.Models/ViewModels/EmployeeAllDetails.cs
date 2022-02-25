using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.ViewModels
{
    public class EmployeeAllDetails: EmployeeIndexModels
    {
        public EmployeeAllDetails()
        {
            this.user = new User();
        }
        public User user { get; set; }
    }
}
