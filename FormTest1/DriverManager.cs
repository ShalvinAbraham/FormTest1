using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace FormTest1
{
    public class DriverManager : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        internal void Initialize(string browser, string timeoutMinutes)
        {
            switch (browser)
            {
                case "IE":
                    Driver = new InternetExplorerDriver();
                    break;

                case "Firefox":
                    Driver = new FirefoxDriver();
                    break;

                default:
                    Driver = new ChromeDriver();
                    break;
            }

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(Convert.ToDouble(timeoutMinutes));
        }

        public void Dispose()
        {
            Driver.Close();
            Driver.Quit();
            Driver = null;
        }

        ~DriverManager()
        {
            Dispose();
        }
    }
}