using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business.BussinessRepository
{
    public interface ILoginManager
    {
        bool CheckUser(LoginUser loginUser);
        User GetUserDetails(string UserMailId);
    }
}
