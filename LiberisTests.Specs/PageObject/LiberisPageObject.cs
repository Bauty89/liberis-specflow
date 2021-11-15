using OpenQA.Selenium;

namespace LiberisTests.Specs.PageObject
{
    class LiberisPageObject
    {
        private const string Url = "https://www.liberis.com";

        private readonly IWebDriver driver;

        public LiberisPageObject(IWebDriver webDriver) => driver = webDriver;

        private IWebElement GetADemoHome => driver.FindElement(By.XPath("//*[@id='site - navigation']/div[1]/a"));
        private IWebElement GetADemo => driver.FindElement(By.XPath("//*[@id='site - inner - wrapper']/main/section/div[2]/div/div[2]/div/a"));
        private IWebElement ErrorMessage => driver.FindElement(By.XPath("//*[@id='site - inner - wrapper']/main/section/div[2]/div/div[2]/div/div[2]/div"));
        
        public void ClickGetADemoHome()
        {
            GetADemoHome.Click();
        }

        public void ClickGetADemo()
        {
            GetADemo.Click();
        }

        public string GetErrorMessage => ErrorMessage.Text;

        public void OpenBrowserIfClosed()
        {
            if (driver.Url != Url)
            {
                driver.Url = Url;
            }
        }

    }
}
