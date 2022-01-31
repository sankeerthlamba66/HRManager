﻿using HRManager.Models.EntityViews;
using HRManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity
{
    public class LoginQueries
    {
        private Context context { get; set; }
        public LoginQueries(Context _context)
        {
            context = _context;
        }
        public bool CheckUser(User user)
        {
            var userDetails = context.Users.Where(s => s.UserName == user.UserName && s.Password.Equals(user.Password)).Select(s=>s);
            if(userDetails is not null)
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
