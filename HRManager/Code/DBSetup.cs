namespace HRManager.Code
{
    public class DBSetup
    {
        public static void IntializeConfig(WebApplicationBuilder builder)
        {
            var HRManagerDetails = builder.Configuration.GetValue<String>("ConnectionStrings:HRManager");
            HRManager.Business.Helpers.SetupManager.IntializeHRConfig(HRManagerDetails);
        }

    }
}
