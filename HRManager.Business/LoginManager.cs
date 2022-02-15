using HRManager.Business.BussinessRepository;
using HRManager.Data.Entity;
using HRManager.Models.EntityViews;
using HRManager.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business
{
    public class LoginManager:ILoginManager
    {
        public bool CheckUser(LoginUser loginUser)
        {
            return new LoginQueries().CheckUser(loginUser);
        }

        public User GetUserDetails(string UserName)
        {
            return new LoginQueries().GetUserDetails(UserName);
        }
    }
}
