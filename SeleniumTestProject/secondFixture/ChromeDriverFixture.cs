﻿namespace SeleniumTestProject.secondFixture
{
    public class ChromeDriverFixture : DriverFixture
    {
        protected override void InitializeDriver()
        {
            Driver.Start(BrowserType.Chrome);
        }

        public override int WaitForElementTimeout => 40; 
    }
}
