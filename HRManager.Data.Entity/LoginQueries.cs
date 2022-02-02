using HRManager.Models.EntityViews;
using HRManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManager.Models.Views;
using HRManager.Utilities;

namespace HRManager.Data.Entity
{
    public class LoginQueries
    {
        private readonly Context context=new Context();
        
        public bool CheckUser(LoginUser loginUser)
        {
            try
            {
                var userDetails = context.Users.Where(s => s.UserName.Equals(loginUser.UserName) && s.Password.Equals(loginUser.Password)).Select(s => s);
                if (userDetails != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return false;
        }
        public User GetUserDetails(string UserName)
        {
            User user = new User();
            try
            {
                var userDetails = context.Users.Where(s => s.UserName == UserName).FirstOrDefault();
                user.Id = userDetails.Id;
                user.UserName = userDetails.UserName;
                user.Roles = userDetails.Roles;
                user.OrganizationId = userDetails.OrganizationId;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return user;
        }
    }
}
