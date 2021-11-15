using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace LiberisTests.Specs.PageObject
{
    class LiberisPageObject
    {
        private const string Url = "https://www.liberis.com";

        private readonly IWebDriver driver; 

        public LiberisPageObject(IWebDriver webDriver) => driver = webDriver;

        private IWebElement GetADemoHome => driver.FindElement(By.XPath("//*[@id='site-navigation']/div[1]/a"));
        private IWebElement GetADemo => driver.FindElement(By.XPath("//*[@id='site-inner-wrapper']/main/section/div[2]/div/div[2]/div/a"));
        private IWebElement ErrorMessage => driver.FindElement(By.ClassName("ph-error-inner"));
        
        public void ClickGetADemoHome()
        {
            GetADemoHome.Click();
        }

        public void ClickGetADemo()
        {
            GetADemo.Click();
        }

        public void Wait()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Timeout = TimeSpan.FromSeconds(5);

        }

        public string GetErrorMessage()
        {
            return ErrorMessage.Text;
        }

        public void OpenBrowserIfClosed()
        {
            if (driver.Url != Url)
            {
                driver.Url = Url;
            }
        }

    }
}
