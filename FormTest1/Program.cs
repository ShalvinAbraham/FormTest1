using OpenQA.Selenium.Chrome;
using System;

namespace FormTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(2);
            driver.Navigate().GoToUrl("https://satlearn.000webhostapp.com/form.php");

            var homePage = new HomePage(driver);

            homePage.Name.SendKeys("Name1");
            homePage.Email.SendKeys("mail@domain.com");
            homePage.Phone.SendKeys("123456");
            homePage.Message.SendKeys("Message 00001");
            homePage.Captcha.SendKeys("123");
            homePage.SubmitForm();

            driver.Close();
            driver.Quit();
        }
    }
}
