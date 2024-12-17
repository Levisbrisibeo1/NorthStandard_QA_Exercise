using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using NorthStand_QA_Exercise.Pages;

namespace NorthStandard_QA_Exercise.StepDefinitions
{
    [Binding]
    public class CheckPageTitleSteps
    {
        private IWebDriver _driver;
        private SeleniumHomePage _seleniumHomePage;

        public CheckPageTitleSteps()
        {
            _driver = null!;
            _seleniumHomePage = null!;
        }

        [Given(@"I have set up the Chrome driver")]
        public void GivenIHaveSetUpTheChromeDriver()
        {
            // Initialize the Chrome Driver and maximize the browser
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            Console.WriteLine("ChromeDriver is set up and browser window maximized.");

            // Initialize the page object
            _seleniumHomePage = new SeleniumHomePage(_driver);
        }

        [When(@"I navigate to the Selenium homepage")]
        public void WhenINavigateToTheSeleniumHomepage()
        {
            // Navigate to the Selenium homepage
            _seleniumHomePage.NavigateTo();

            Console.WriteLine("Navigated to the Selenium homepage.");
        }

        [Then(@"the page title should be ""(.*)""")]
        public void ThenThePageTitleShouldBe(string expectedTitle)
        {
            // Retrieve the actual page title
            string actualTitle = _seleniumHomePage.GetPageTitle();

            // Log the expected and actual results
            Console.WriteLine($"Expected Page Title: \"{expectedTitle}\"");
            Console.WriteLine($"Actual Page Title: \"{actualTitle}\"");

            // Perform assertion
            Assert.AreEqual(expectedTitle, actualTitle,
                $"Page title mismatch! Expected: \"{expectedTitle}\", but got: \"{actualTitle}\"");

            Console.WriteLine("Page title verified successfully.");

            Thread.Sleep(500);

            // Quit the browser
            _driver.Quit();
            Console.WriteLine("Browser closed.");
        }
    }
}
