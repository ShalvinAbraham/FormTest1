using OpenQA.Selenium;

namespace FormTest1
{
    public class ResponsePage
    {
        private IWebDriver driver;
        public ResponsePage()
        {
            driver = Context.Driver;
        }

        public string Title => driver.Title;

        public IWebElement ThanksMessage => driver.FindElement(By.Id("feedback_thx"));

        public IWebElement VisitorName => driver.FindElement(By.Id("response_visitor_name"));

        public IWebElement VisitorEmail => driver.FindElement(By.Id("response_visitor_email"));

        public IWebElement VisitorPhone => driver.FindElement(By.Id("response_visitor_phone"));

        public IWebElement VisitorIP => driver.FindElement(By.Id("response_visitor_ip"));

        public IWebElement VisitorBrowser => driver.FindElement(By.Id("response_visitor_browser"));

        public IWebElement VisitorMessage => driver.FindElement(By.Id("response_visitor_message"));

        public IWebElement AnotherFeedback => driver.FindElement(By.LinkText("Click here to submit another feedback"));

        public void SubmitAgain() => AnotherFeedback.Click();
    }
}