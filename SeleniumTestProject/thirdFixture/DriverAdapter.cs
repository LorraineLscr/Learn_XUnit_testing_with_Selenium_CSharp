using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using WebDriverManager;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Edge;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTestProject.thirdFixture
{
    public class DriverAdapter : IDisposable
    {
        private const int WAIT_FOR_ELEMENT_TIMEOUT = 30;
        private IWebDriver _driver;
        private WebDriverWait _webDriverWait;

        public void Start(BrowserType browserType)
        {
            switch(browserType)
            {
                case BrowserType.Chrome:
                    new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.Latest);
                    _driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    new DriverManager().SetUpDriver(new FirefoxConfig(), VersionResolveStrategy.Latest);
                    _driver = new FirefoxDriver();
                    break;
                case BrowserType.Safari:
                    _driver = new SafariDriver();
                    break;
                case BrowserType.Edge:
                    new DriverManager().SetUpDriver(new EdgeConfig(), VersionResolveStrategy.Latest);
                    _driver = new EdgeDriver();
                    break;
                default:
                    break;
            }
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(WAIT_FOR_ELEMENT_TIMEOUT));
            _driver.Manage().Window.Maximize();
        }

        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ValidateInnerTextIs(IWebElement resultSpan, string expectedText)
        {
            _webDriverWait.Until(ExpectedConditions.TextToBePresentInElement(resultSpan, expectedText));
        }

        public IWebElement FindElement(By locator)
        {
            return _webDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }
        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
