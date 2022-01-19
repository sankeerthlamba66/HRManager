namespace HRManager.Code
{
    internal static class SessionManager
    {
        internal static int? GetSessionInt(string SessionKey)
        {
            var CurrentContext = new HttpContextAccessor().HttpContext;

            if (CurrentContext is not null)
            {
                return CurrentContext.Session.GetInt32(SessionKey);
            }
            
            return null;
        }

        internal static string? GetSessionString(string SessionKey)
        {
            var CurrentContext = new HttpContextAccessor().HttpContext;

            if (CurrentContext is not null)
            {
                return CurrentContext.Session.GetString(SessionKey);
            }

            return null;
        }

        internal static List<string> GetSessionStringArray(string SessionKey)
        {
            byte[]? SessionVal = GetSessionValue(SessionKey);

            return SessionVal is not null ? System.Text.Encoding.ASCII.GetString(SessionVal).Split(',').ToList() : new List<string> { string.Empty };
        }

        internal static byte[]? GetSessionValue(string SessionKey)
        {
            byte[]? SessionValue = null;
            var CurrentContext = new HttpContextAccessor().HttpContext;

            if (CurrentContext is not null)
            {
                SessionValue = CurrentContext.Session.Get(SessionKey);
            }

            return SessionValue;
        }

        internal static void SetSessionInt(string SessionKey, int SessionValue)
        {
            var CurrentContext = new HttpContextAccessor().HttpContext;

            if (CurrentContext is not null)
            {
                CurrentContext.Session.SetInt32(SessionKey, SessionValue);
            }
        }

        internal static void SetSessionString(string SessionKey, string SessionValue)
        {
            var CurrentContext = new HttpContextAccessor().HttpContext;

            if (CurrentContext is not null)
            {
                CurrentContext.Session.SetString(SessionKey, SessionValue);
            }
        }

        internal static void SetSessionStringArray(string SessionKey, List<string> SessionValue)
        {
            SetSessionValue(SessionKey, System.Text.Encoding.ASCII.GetBytes(String.Join(',', SessionValue)));
        }

        internal static void SetSessionValue(string SessionKey, byte[] SessionValue)
        {
            var CurrentContext = new HttpContextAccessor().HttpContext;

            if (CurrentContext is not null)
            {
                CurrentContext.Session.Set(SessionKey, SessionValue);
            }
        }
    }
}
