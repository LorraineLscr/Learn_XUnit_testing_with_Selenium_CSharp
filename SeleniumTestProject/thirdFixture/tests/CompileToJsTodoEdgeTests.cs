using OpenQA.Selenium;
using System.Collections.Generic;
using Xunit;


namespace SeleniumTestProject.thirdFixture
{
    public class CompileToJsTodoEdgeTests : IClassFixture<EdgeDriverFixture>, IClassFixture<PagesFixture>
    {
        private readonly EdgeDriverFixture _fixture;
        private readonly PagesFixture _pagesFixture;

        public CompileToJsTodoEdgeTests(EdgeDriverFixture fixture, PagesFixture pagesFixture)
        {
            _fixture = fixture;
            _pagesFixture = new PagesFixture();
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
            var itemsToAdd = new List<string>() { "Clean the car", "Clean the house", "Buy Ketchup" };
            var itemsToCheck = new List<string>() { "Buy Ketchup" };

            _pagesFixture.ToDoFacade.VerifyTodoListCreatedSuccefully(technology, itemsToAdd, itemsToCheck, 2);
        }
    }
}
