using OpenQA.Selenium;

namespace LiberisTests.PageObject
{
    class LiberisPageObject
    {

        private readonly IWebDriver driver;

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
    }
}
