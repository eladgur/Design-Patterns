using System;

namespace Logic
{
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;
    public delegate void UserLoggedIn(User i_LoggedInUser);

    public static class ConnectManager
    {
        public static event UserLoggedIn m_ReportUserLoggedInDelegates;
        private const string k_AppID = "2001558203230345";
        private static readonly string[] sr_Permissions =
            {
                "public_profile", "user_birthday", "user_friends", "user_events", "user_hometown", "user_likes",
                "user_location", "user_photos", "user_posts", "user_status", "user_tagged_places", "user_gender"
            };
        private static LoginResult s_LoginResult;
        private static AppSettings s_AppSettings;

        public static AppSettings Settings
        {
            get
            {
                if (s_AppSettings == null)
                {
                    s_AppSettings = AppSettings.Load();
                }

                return s_AppSettings;
            }
        }

        public static void SaveSettings()
        {
            Settings.Save();
        }

        public static void Login()
        {
            bool v_Connected = !(s_LoginResult == null);

            if (!v_Connected)
            {
                if (!Settings.RememberMe || Settings.AccessToken == null)
                {
                    s_LoginResult = FacebookService.Login(k_AppID, sr_Permissions);
                }
                else
                {
                    s_LoginResult = FacebookService.Connect(Settings.AccessToken);
                }

                if (string.IsNullOrEmpty(s_LoginResult.AccessToken))
                {
                    throw new Exception(s_LoginResult.ErrorMessage);
                }
            }

            Settings.AccessToken = s_LoginResult.AccessToken;
            notifyUserLoggedIn();
        }

        private static void notifyUserLoggedIn()
        {
            if (m_ReportUserLoggedInDelegates != null)
            {
                m_ReportUserLoggedInDelegates.Invoke(s_LoginResult.LoggedInUser);
            }
        }

        public static void Logout()
        {
            Settings.RememberMe = false;
            FacebookService.Logout(() => s_LoginResult = null);
        }
    }
}