using OpenQA.Selenium;

namespace SeleniumTestProject.thirdFixture.pages
{
    public class MainPage
    {
        private readonly DriverAdapter _driver;

        public MainPage(DriverAdapter driver)
        {
            _driver = driver;
        }

        public string Url => "https://todomvc.com/";

        public void Open()
        {
            _driver.GoToUrl("https://todomvc.com/");
        }

        public void OpenTechnologyApp(string name)
        {
            IWebElement technologyLink = _driver.FindElement(By.LinkText(name));
            technologyLink.Click();
        }

    }
}
