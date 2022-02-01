using HRManager.Models.EntityViews;
using HRManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;

namespace HRManager.Data.Entity
{
    public class LoginQueries
    {
        private readonly Context context=new Context();
        
        public bool CheckUser(LoginUser loginUser)
        {
            var userDetails = context.Users.Where(s => s.UserName.Equals(loginUser.UserName) && s.Password.Equals(loginUser.Password)).Select(s=>s);
            if(userDetails!=null)
            {
                return true;
            }
            return false;
        }
        public User GetUserDetails(string UserName)
        {
            var userDetails = context.Users.Where(s => s.UserName == UserName).FirstOrDefault();
            User user = new User();
            user.Id = userDetails.Id;
            user.UserName = userDetails.UserName;
            user.Roles = userDetails.Roles;
            user.OrganizationId = userDetails.OrganizationId;
            return user;
        }
    }
}
