namespace SeleniumTestProject.secondFixture
{
    public class FirefoxDriverFixture : DriverFixture
    {
        protected override void InitializeDriver()
        {
            Driver.Start(BrowserType.Firefox);
        }

        public override int WaitForElementTimeout => 60;
    }
}
