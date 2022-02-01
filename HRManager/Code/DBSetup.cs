namespace HRManager.Code
{
    public class DBSetup
    {
        public static void IntializeConfig(WebApplicationBuilder builder)
        {
            var HRManagerDetails = builder.Configuration.GetSection("HRManager");
            HRManager.Business.Helpers.SetupManager.IntializeHRConfig(HRManagerDetails);
        }

    }
}
