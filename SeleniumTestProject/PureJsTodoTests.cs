using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumTestProject.firstFixture;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using Xunit;

[assembly: CollectionBehavior(CollectionBehavior.CollectionPerClass, MaxParallelThreads = 4)]
namespace XUnitParallelTestting
{
    public class PureJsTodoTests : IClassFixture<DriverFixture>
    {
        private readonly DriverFixture _fixture;

        public PureJsTodoTests(DriverFixture fixture)
        {
            _fixture = fixture;
        }

        [Theory]
        [InlineData("Backbone.js")]
        [InlineData("AngularJS")]
        [InlineData("React")]
        [InlineData("Vue.js")]
        [InlineData("CanJS")]
        [InlineData("Ember.js")]
        [InlineData("KnockoutJS")]
        [InlineData("Marionette.js")]
        [InlineData("Polymer")]
        [InlineData("Angular 2.0")]
        [InlineData("Dart")]
        public void VerifyTodoListCreatedSuccessfully(string technology)
        {
            _fixture.Driver.Navigate().GoToUrl("https://todomvc.com/");
            OpenTechnologyApp(technology);
            AddNewToDoItem("Clean the car");
            AddNewToDoItem("Clean the house");
            AddNewToDoItem("Buy Ketchup");
            GetItemCheckBox("Buy Ketchup").Click();
            AssertLeftItems(2);
        }

        private void AssertLeftItems(int expectedCount)
        {
            var resultSpan = WaitAndFindElement(By.XPath("//footer/span"));
            if (expectedCount <= 0)
            {
                ValidateInnerTexIs(resultSpan, $"{expectedCount} item left");
            }
            else
            {
                ValidateInnerTexIs(resultSpan, $"{expectedCount} items left");
            }
        }

        private void ValidateInnerTexIs(IWebElement resultSpan, string expectedText)
        {
            _fixture.WebDriverWait.Until(ExpectedConditions.TextToBePresentInElement(resultSpan, expectedText));
        }

        private IWebElement GetItemCheckBox(string todoItem)
        {
            return WaitAndFindElement(By.XPath($"//label[text()='{todoItem}']/preceding-sibling::input"));
        }

        private void AddNewToDoItem(string todoItem)
        {
            var todoInput = WaitAndFindElement(By.XPath("//input[@placeholder='What needs to be done?']"));
            todoInput.SendKeys(todoItem);
            todoInput.SendKeys(Keys.Enter);
        }

        private void OpenTechnologyApp(string name)
        {
            IWebElement technologyLink = WaitAndFindElement(By.LinkText(name));
            technologyLink.Click();
        }
        private IWebElement WaitAndFindElement(By locator)
        {
            return _fixture.WebDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }
    }
}
