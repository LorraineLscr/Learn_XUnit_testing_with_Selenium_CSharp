namespace SeleniumTestProject.thirdFixture
{
    public class FirefoxDriverFixture : DriverFixture
    {
        protected override void InitializeDriver()
        {
            Driver.Value.Start(BrowserType.Firefox);
        }

        public override int WaitForElementTimeout => 60;
    }
}
