using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity
{
    public class Setup
    {
        internal static String DBConnectionString = String.Empty;
        public static void IntializeHRConfig(string HRManagerDetails)
        {
            Setup.DBConnectionString = HRManagerDetails;
        }
    }
}
