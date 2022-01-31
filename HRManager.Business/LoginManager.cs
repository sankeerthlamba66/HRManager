using HRManager.Business.BussinessRepository;
using HRManager.Data.Entity;
using HRManager.Data.Entity.EntityRepository;
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
        private readonly ILoginQueries loginQueries;
        public LoginManager(ILoginQueries _loginQueries)
        {
            loginQueries = _loginQueries;
        }
        public bool CheckUser(LoginUser loginUser)
        {
            return loginQueries.CheckUser(loginUser);
        }

        public User GetUserDetails(string UserName)
        {
            return loginQueries.GetUserDetails(UserName);
        }
    }
}
