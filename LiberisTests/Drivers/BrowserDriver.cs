using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace LiberisTests.Drivers

{
    public class BrowserDriver
    {
        private IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public BrowserDriver(ScenarioContext scenarioCotnext) => _scenarioContext = scenarioCotnext;

        public IWebDriver Setup()
        {
            driver = new ChromeDriver();
            _scenarioContext.Set(driver, "BrowserDriver");
            return driver;
        }


    }
}