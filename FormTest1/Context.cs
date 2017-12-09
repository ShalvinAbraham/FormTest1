using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;

namespace FormTest1
{
    public static class Context
    {
        private static IWebDriver driver = null;

        public static IWebDriver Driver { get { return driver; } }
        public static string BaseURL { get; private set; }

        static Context()
        {
            BaseURL = ConfigurationManager.AppSettings["BaseURL"];
            var browser = ConfigurationManager.AppSettings["Browser"] ?? "Chrome";
            var timeoutMinutes = ConfigurationManager.AppSettings["TimeoutMinutes"] ?? "2";

            InitializeDriver(browser, timeoutMinutes);
        }

        private static void InitializeDriver(string browser, string timeoutMinutes)
        {
            switch (browser)
            {
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(Convert.ToDouble(timeoutMinutes));
        }

        public static void CloseDriver()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
