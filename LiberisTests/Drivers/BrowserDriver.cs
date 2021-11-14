using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LiberisTests.Drivers

{
    public class BrowserDriver : IDisposable
    {
        private readonly Lazy<IWebDriver> currentWebDriverLazy;
        private bool isDisposed;

        public BrowserDriver() => currentWebDriverLazy = new Lazy<IWebDriver>(CreateWebDriver);

        public IWebDriver Current => currentWebDriverLazy.Value;

        private IWebDriver CreateWebDriver()
        {
            var chromeDriver = new ChromeDriver();

            return chromeDriver;
        }



        public void Dispose()
        {
            if (isDisposed)
            {
                return;
            }

            if (currentWebDriverLazy.IsValueCreated)
            {
                Current.Quit();
            }

            isDisposed = true;
        }

    }
}