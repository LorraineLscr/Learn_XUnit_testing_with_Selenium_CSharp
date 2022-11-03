using OpenQA.Selenium;
using System.Collections.Generic;
using Xunit;


namespace SeleniumTestProject.thirdFixture
{
    public class CompileToJsTodoChromeTests : IClassFixture<ChromeDriverFixture>, IClassFixture<PagesFixture>, 
        IClassFixture<TestDataFixture>
    {
        private readonly ChromeDriverFixture _fixture;
        private readonly PagesFixture _pagesFixture;
        private readonly TestDataFixture _testDataFixture;

        public CompileToJsTodoChromeTests(ChromeDriverFixture fixture, PagesFixture pagesFixture, TestDataFixture testDataFixture)
        {
            _fixture = fixture;
            _pagesFixture = new PagesFixture();
            _testDataFixture = testDataFixture;
        }

        [Theory]
        [InlineData("Elm")]
        [InlineData("Closure")]
        [InlineData("Vanilla JS")]
        [InlineData("jQuery")]
        [InlineData("cujoJS")]
        [InlineData("Spine")]
        [InlineData("Dojo")]
        [InlineData("Mithril")]
        [InlineData("Kotlin + React")]
        [InlineData("Firebase + AngularJS")]
        [InlineData("Vanilla ES6")]
        public void VerifyTodoListCreatedSuccessfully(string technology)
        {
            _pagesFixture.ToDoFacade.VerifyTodoListCreatedSuccefully(technology, _testDataFixture.ItemsToAdd,
                _testDataFixture.ItemsToCheck, _testDataFixture.ExpectedItemsLeft);
        }

    }
}
