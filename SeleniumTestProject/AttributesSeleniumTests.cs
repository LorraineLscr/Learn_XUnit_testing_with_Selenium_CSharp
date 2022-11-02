using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using Xunit;

namespace SeleniumTestProject
{
    public class AttributesSeleniumTests : IDisposable
    { 
        private IWebDriver _driver;

        public AttributesSeleniumTests()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Fact]
        public void ProperCheckboxSelected()
        { 
           _driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");
            IWebElement todoInput = _driver.FindElement(By.Id("sampletodotext"));

            DateTime birthDay = new DateTime(1992, 12, 18); // us 12/18/1992
            todoInput.SendKeys(birthDay.ToString("d")); // date courte

            var addButton = _driver.FindElement(By.Id("addbutton"));
            addButton.Click();

            var todoCheckboxes = _driver.FindElement(By.XPath("//li[@ng-repeat]/input"));

            todoCheckboxes.Last().Click();

            var todoInfos = _driver.FindElement(By.XPath("//li[@ng-repeat]/span"));

            Assert.Equal("12/18/1992", todoInfos.Last().Text);
        }

        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
