using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumTestProject.thirdFixture
{
    public class TestDataFixture : IDisposable
    {
        public TestDataFixture()
        {
            var autoFixture = new Fixture();
            ItemsToAdd = autoFixture.CreateMany<string>(5).ToList();
            ItemsToCheck = ItemsToAdd.Skip(3).ToList();
            ExpectedItemsLeft = 3; 
        }
        public List<string> ItemsToAdd { get; set; }
        public List<string> ItemsToCheck { get; set; }
        public int ExpectedItemsLeft { get; set; }
        public void Dispose()
        {

        }
    }
}
