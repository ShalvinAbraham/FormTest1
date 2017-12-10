using OpenQA.Selenium;
using System.Configuration;

namespace FormTest1
{
    public static class Context
    {
        private static DriverManager mgr = new DriverManager();

        public static IWebDriver Driver { get { return mgr.Driver; } }
        public static string BaseURL { get; private set; }
        public static string Browser { get; private set; }
        public static string TimeoutMinutes { get; private set; }

        static Context()
        {
            BaseURL = ConfigurationManager.AppSettings["BaseURL"];
            Browser = ConfigurationManager.AppSettings["Browser"] ?? "Chrome";
            TimeoutMinutes = ConfigurationManager.AppSettings["TimeoutMinutes"] ?? "2";

            mgr.Initialize(Browser, TimeoutMinutes);
        }
    }
}
