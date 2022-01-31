using HRManager.Models.EntityViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.EntityRepository
{
    public interface ILoginQueries
    {
        bool CheckUser(User user);
        User GetUserDetails(string UserName);
    }
}
