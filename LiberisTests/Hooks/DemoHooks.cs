using LiberisTests.Drivers;
using LiberisTests.PageObject;
using TechTalk.SpecFlow;

namespace LiberisTests.Hooks
{
    class DemoHooks
    {
        [BeforeScenario("Demo")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var liberisPageObject = new LiberisPageObject(browserDriver.Current);
            liberisPageObject.OpenBrowser();
        }
    }
}
