﻿namespace HRManager.Code
{
    public static class Session
    {
        public static int UserId
        {
            get
            {
                return SessionManager.GetSessionInt("UserId") ?? -1;
            }
            set
            {
                SessionManager.SetSessionInt("UserId", value);
            }
        }

        public static string UserName
        {
            get
            {
                return SessionManager.GetSessionString("UserName") ?? String.Empty;
            }
            set
            {
                SessionManager.SetSessionString("UserName", value);
            }
        }

        public static List<string> UserRoles
        {
            get
            {
                return SessionManager.GetSessionStringArray("UserRoles");
            }
            set
            {
                SessionManager.SetSessionStringArray("UserRoles", value);
            }
        }
    }
}