using LiberisTests.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace LiberisTests.Hooks
{
    [Binding]
    public sealed class LiberisDemoHook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private readonly ScenarioContext _scenarioContext;

        public LiberisDemoHook(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [BeforeTestRun]
        public void BeforeScenario()
        {
            BrowserDriver browserDriver = new BrowserDriver(_scenarioContext);
            _scenarioContext.Set(browserDriver, "BrowserDriver");
        }

        [AfterTestRun]
        public void AfterScenario()
        {
            _scenarioContext.Get<IWebDriver>("BrowserDriver").Quit();
        }
    }
}
