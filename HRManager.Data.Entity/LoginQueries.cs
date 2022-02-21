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
                var userDetails = context.Users.Where(s => s.UserMailId.Equals(loginUser.UserMailId) && s.Password.Equals(loginUser.Password)).Select(s => s);
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
        public User GetUserDetails(string UserMailId)
        {
            User user = new User();
            try
            {
                var userDetails = context.Users.Where(s => s.UserMailId.Equals(UserMailId)).FirstOrDefault();
                if (userDetails is not null)
                {
                    user.Id = userDetails.Id;
                    user.UserName = userDetails.UserName;
                    user.UserMailId = userDetails.UserMailId;
                    user.Roles = userDetails.Roles;
                    user.OrganizationId = userDetails.OrganizationId;
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex.Message);
            }
            return user;
        }
    }
}
