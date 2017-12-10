using System;

namespace FormTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Scenario1();

            Scenario2();

            Console.Read();
        }

        private static void Scenario1()
        {
            var homePage = new HomePage();

            homePage.Navigate();

            homePage.Name.SendKeys("Name1");
            homePage.Email.SendKeys("mail@domain.com");
            homePage.Phone.SendKeys("123456");
            homePage.Message.SendKeys("Message 00001");
            homePage.Captcha.SendKeys("123");
            homePage.SubmitForm();

            Console.WriteLine("Scenario1");
            Console.WriteLine(homePage.Title.Equals("Feedback from Name1") ? "PASS" : "FAIL");
        }

        private static void Scenario2()
        {
            var homePage = new HomePage();

            homePage.Navigate();

            homePage.Name.SendKeys("Name1");
            homePage.Email.SendKeys("mail.vvv");
            homePage.Phone.SendKeys("1234562");
            homePage.Message.SendKeys("Message 00002");
            homePage.Captcha.SendKeys("1234");
            homePage.SubmitForm();

            Console.WriteLine("Scenario2");
            Console.WriteLine(homePage.Title.Equals("Feedback from Name1") ? "PASS" : "FAIL");
        }
    }
}
