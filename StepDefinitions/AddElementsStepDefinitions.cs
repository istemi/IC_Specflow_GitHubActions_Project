using SpecFlow_GithubActions.Drivers;
using SpecFlow_GithubActions.Pages;
using OpenQA.Selenium;


namespace SpecFlow_GithubActions.StepDefinitions
{
    [Binding]
    public class AddElementsStepDefinitions
    {
        public AddElementsPage addElementsPage = new AddElementsPage();

        public AddElementsStepDefinitions(AddElementsPage addElementsPage)
        {
            this.addElementsPage = addElementsPage;
        }

        [When(@"I navigate to the herokuapp add elements page")]
        public void WhenINavigateToTheHerokuappAddElementsPage()
        {
            Driver.GetDriver().Url = "https://the-internet.herokuapp.com/add_remove_elements/l";
            Driver.GetDriver().Manage().Window.Maximize();
            Driver.GetDriver().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Driver.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Given(@"I am on the add-remove elements page")]
        public void GivenIAmOnTheAdd_RemoveElementsPage()
        {            
            var actualPageHeader = Driver.GetDriver().FindElement(By.XPath(addElementsPage.pageHeaderXpath)).Text;
            Assert.True(actualPageHeader != null,"we could not land on add elements page, no header is on the page");
            Assert.True(actualPageHeader.Equals(addElementsPage.expectedPageHeader), $"page header is {actualPageHeader} which was expected as {addElementsPage.expectedPageHeader}");
        }

        [When(@"I click on the add element button (.*) times")]
        public void WhenIClickOnTheAddElementButtonTimes(int N)
        {
            for (int numberOfElements = 1; numberOfElements <= N; numberOfElements++)
            {
                Driver.GetDriver().FindElement(By.XPath(addElementsPage.addElementButtonXpath)).Click();
            }
        }

        [Then(@"I should see (.*) elements on the page")]
        public void ThenIShouldSeeElementsOnThePage(int N)
        {
            var createdElements=Driver.GetDriver().FindElements(By.XPath(addElementsPage.createdElementsXpath));
            var numberOfCreatedElements = createdElements.Count;
            Assert.True(numberOfCreatedElements.Equals(N), $"the number of created elements is {numberOfCreatedElements}, but it was expected as {N}");
        }

    }
}