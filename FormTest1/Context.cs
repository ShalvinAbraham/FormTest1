using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTest1
{
    public static class Context
    {
        private static IWebDriver driver = null;

        public static IWebDriver Driver { get { return driver ?? InitializeDriver(); } }
        public static string BaseURL { get; private set; }

        static Context()
        {
            BaseURL = @"https://satlearn.000webhostapp.com/";
        }

        private static IWebDriver InitializeDriver()
        {
            var browser = "Chrome";
            var timeoutMinutes = "2";

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

            return driver;
        }

        public static void CloseDriver()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
