using HRManager.Data.Entity;
using HRManager.Data.Entity.EntityRepository;
using HRManager.Models.EntityViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business
{
    public class LoginManager
    {
        private readonly ILoginQueries loginQueries;
        public LoginManager(ILoginQueries _loginQueries)
        {
            loginQueries = _loginQueries;
        }
        public bool CheckUser(User user)
        {
            return loginQueries.CheckUser(user);
        }

        public User GetUserDetails(string UserName)
        {
            return loginQueries.GetUserDetails(UserName);
        }
    }
}
