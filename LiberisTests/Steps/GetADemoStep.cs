using LiberisTests.Drivers;
using LiberisTests.PageObject;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace LiberisTests.Steps
{
    [Binding]
    public class GetADemoStep
    {
        private readonly LiberisPageObject liberisPageObject;

        public GetADemoStep(BrowserDriver browserDriver)
        {
            liberisPageObject = new LiberisPageObject(browserDriver.Current);
        }

        [Given("I navigate to Get a demo page")]
        public void GivenINavigateToGetaDemo()
        {
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
