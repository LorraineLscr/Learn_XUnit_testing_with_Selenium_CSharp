using SeleniumTestProject.thirdFixture.pages;
using System.Collections.Generic;

namespace SeleniumTestProject.thirdFixture
{
    public class ToDoFacade
    {
        private readonly MainPage _mainPage;
        private readonly ToDoAppPage _toDoAppPage;

        public ToDoFacade(MainPage mainPage, ToDoAppPage toDoAppPage)
        {
            _mainPage = mainPage;
            _toDoAppPage = toDoAppPage;
        }

        public void VerifyTodoListCreatedSuccefully(string technology, List<string> itemsToAdd, List<string> itemsToCheck,
            int expectedItemsLeft)
        {
            _mainPage.Open();
            _mainPage.OpenTechnologyApp(technology);
            itemsToAdd.ForEach(item => _toDoAppPage.AddNewToDoItem(item));
            itemsToAdd.ForEach(item => _toDoAppPage.GetItemCheckBox(item));
            _toDoAppPage.AssertLeftItems(expectedItemsLeft); 
        }
    }
}
