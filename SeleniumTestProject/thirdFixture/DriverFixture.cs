using System;
using System.Threading;

namespace SeleniumTestProject.thirdFixture

{
    public abstract class DriverFixture : IDisposable
    {
        private const int WAIT_FOR_ELEMENT_TIMEOUT = 30; 
        public DriverFixture()
        {
            Driver = new ThreadLocal<DriverAdapter>(()=> new DriverAdapter());
            InitializeDriver();
        }

        protected abstract void InitializeDriver();
        
        public static ThreadLocal<DriverAdapter> Driver { get; set; }

        public virtual int WaitForElementTimeout { get; set; } =  WAIT_FOR_ELEMENT_TIMEOUT;

        public void Dispose()
        {
            Driver.Value.Dispose();
        }
    }
}
