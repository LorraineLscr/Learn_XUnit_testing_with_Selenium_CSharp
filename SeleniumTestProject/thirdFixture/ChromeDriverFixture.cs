namespace SeleniumTestProject.thirdFixture
{
    public class ChromeDriverFixture : DriverFixture
    {
        protected override void InitializeDriver()
        {
            Driver.Value.Start(BrowserType.Chrome);
        }

        public override int WaitForElementTimeout => 40; 
    }
}
