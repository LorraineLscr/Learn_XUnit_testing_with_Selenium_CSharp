namespace SeleniumTestProject.thirdFixture
{
    public class SafariDriverFixture : DriverFixture
    {
        protected override void InitializeDriver()
        {
            Driver.Value.Start(BrowserType.Safari);
        }

        public override int WaitForElementTimeout => 20;
    }
}