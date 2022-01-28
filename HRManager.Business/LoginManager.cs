using HRManager.Data.Entity;
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
        public bool CheckUser(User user)
        {
            return new LoginQueries().CheckUser(user);
        }

        public User GetUserDetails(int? UserId)
        {
            return new LoginQueries().GetUserDetails(UserId);
        }
    }
}
