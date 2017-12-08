using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace FormTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            var homePage = new HomePage();

            homePage.Navigate();

            homePage.Name.SendKeys("Name1");
            homePage.Email.SendKeys("mail@domain.com");
            homePage.Phone.SendKeys("123456");
            homePage.Message.SendKeys("Message 00001");
            homePage.Captcha.SendKeys("123");
            homePage.SubmitForm();

            Context.CloseDriver();
        }
    }
}
