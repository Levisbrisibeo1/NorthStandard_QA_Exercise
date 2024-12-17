using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NorthStand_QA_Exercise.Pages
{
    public class SeleniumHomePage : BasePage
    {
        private const string Url = "https://www.selenium.dev/";

        public SeleniumHomePage(IWebDriver driver) : base(driver) { }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public string GetPageTitle()
        {
            return Driver.Title;
        }
    }
}
