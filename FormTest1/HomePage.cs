using OpenQA.Selenium;

namespace FormTest1
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Title => driver.Title;

        public IWebElement Name => driver.FindElement(By.Name("visitor_name"));

        public IWebElement Email => driver.FindElement(By.Name("visitor_email"));

        public IWebElement Phone => driver.FindElement(By.Name("visitor_phone"));

        public IWebElement Message => driver.FindElement(By.Name("visitor_message"));

        public IWebElement Captcha => driver.FindElement(By.Name("captcha_code"));

        public IWebElement Submit => driver.FindElement(By.Name("submit"));

        public void SubmitForm()
        {
            Submit.Click();
        }
    }
}
