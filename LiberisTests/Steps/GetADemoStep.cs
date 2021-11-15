using LiberisTests.Drivers;
using LiberisTests.PageObject;
using FluentAssertions;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace LiberisTests.Steps
{
    [Binding]
    public class GetADemoStep
    {

        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        private readonly LiberisPageObject liberisPageObject;
        public GetADemoStep(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [Given("I navigate to Get a demo page in (.*)")]
        public void GivenINavigateToGetaDemo(string url)
        {
            driver = _scenarioContext.Get<BrowserDriver>("BrowserDriver").Setup();
            driver.Url = url;
            liberisPageObject.ClickGetADemoHome();
        }

        [When("I click in Get a demo")]
        public void WhenIClickinGetDemo()
        {
            liberisPageObject.ClickGetADemo();
        }

        [Then("I will be prompted with (.*)")]
        public void ThenIllBePrompted(string result)
        {
            string actualResult = liberisPageObject.GetErrorMessage;

            actualResult.Should().Be(result);
        }
    }
}
