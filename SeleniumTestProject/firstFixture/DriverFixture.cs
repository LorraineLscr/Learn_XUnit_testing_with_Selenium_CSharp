using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.firstFixture

{
    public class DriverFixture : IDisposable
    {
        public DriverFixture(WebDriverWait webDriverWait, IWebDriver driver)
        {
            WebDriverWait = webDriverWait;
            Driver = driver;
        }

        public WebDriverWait WebDriverWait { get; set; }   
        public IWebDriver Driver { get; set; }   
    }
}
