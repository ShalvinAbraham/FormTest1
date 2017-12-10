using System;

namespace FormTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            SuccessfullSubmit("Name1", "mail@domain.com", "123456", "Message 00001");

            Console.Read();
        }

        private static void SuccessfullSubmit(string name, string email, string phone, string message)
        {
            var homePage = new HomePage();
            var responsePage = new ResponsePage();

            homePage.Navigate();

            homePage.Name.SendKeys(name);
            homePage.Email.SendKeys(email);
            homePage.Phone.SendKeys(phone);
            homePage.Message.SendKeys(message);
            homePage.Captcha.SendKeys("123");
            homePage.SubmitForm();

            Console.WriteLine("\nSuccessfull Submit");
            Console.Write("Title :");
            Console.WriteLine(responsePage.Title.Equals($"Feedback from {name}") ? "PASS" : "FAIL");

            Console.Write("Name :");
            Console.WriteLine(responsePage.VisitorName.Text.Equals(name) ? "PASS" : "FAIL");

            Console.Write("Email :");
            Console.WriteLine(responsePage.VisitorEmail.Text.Equals(email) ? "PASS" : "FAIL");

            Console.Write("Phone :");
            Console.WriteLine(responsePage.VisitorPhone.Text.Equals(phone) ? "PASS" : "FAIL");

            Console.Write("Message :");
            Console.WriteLine(responsePage.VisitorMessage.Text.Equals(message) ? "PASS" : "FAIL");
        }
    }
}
