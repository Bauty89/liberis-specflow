using LiberisTests.Specs.Drivers;
using LiberisTests.Specs.PageObject;
using TechTalk.SpecFlow;

namespace LiberisTests.Specs.Hooks
{
    [Binding]
    public sealed class LiberisDemoHook
    {
        [BeforeScenario("GetDemo")]
        public void BeforeScenario(BrowserDriver browserDriver)
        {
            var liberisPageObject = new LiberisPageObject(browserDriver.Current);
            liberisPageObject.OpenBrowserIfClosed();
        }
    }
}
