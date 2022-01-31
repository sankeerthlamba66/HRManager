using HRManager.Models.EntityViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business.BussinessRepository
{
    public interface ILoginManager
    {
        bool CheckUser(User user);
        User GetUserDetails(string UserName);
    }
}
