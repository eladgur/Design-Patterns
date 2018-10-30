using System;

namespace Logic
{
    using System.Drawing;
    using System.IO;
    using System.Runtime.Serialization;

    public class AppSettings
    {
        private const string k_FileName = "AppSettings.xml";
        public string AccessToken { get; set; }
        public bool RememberMe { get; set; }
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }

        public AppSettings()
        {
            RememberMe = false;
            AccessToken = null;
        }

        public void Save()
        {
            using (System.IO.Stream stream = new FileStream(k_FileName, FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(AppSettings));
                serializer.WriteObject(stream, this);
            }
        }

        public static AppSettings Load()
        {
            AppSettings appSettingFromFile = null;
            try
            {
                System.IO.Stream stream = new FileStream(k_FileName, FileMode.Open);
                DataContractSerializer serializer = new DataContractSerializer(typeof(AppSettings));
                appSettingFromFile = serializer.ReadObject(stream) as AppSettings;
                stream.Dispose();
            }
            catch (Exception)
            {
                appSettingFromFile = new AppSettings();
            }

            return appSettingFromFile;
        }
    }
}