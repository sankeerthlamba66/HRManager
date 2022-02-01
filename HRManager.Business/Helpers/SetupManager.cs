using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business.Helpers
{
    public static class SetupManager
    {
        public static void IntializeHRConfig(string HRManagerDetails)
        {
            Data.Entity.Setup.IntializeHRConfig(HRManagerDetails);
        }
    }
}
