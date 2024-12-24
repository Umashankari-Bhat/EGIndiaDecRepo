using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class FullOrangeStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;

        public FullOrangeStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }


        [Given(@"user is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {


            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"user enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
        {

            IWebElement username = _driver.FindElement(By.XPath("//input[@name = 'username']"));

            username.SendKeys(usrname);


            IWebElement password = _driver.FindElement(By.XPath("//input[@name = 'password']"));

            password.SendKeys(passwd);


        }

        [When(@"user clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {


            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

            loginbutton.Click();

            Thread.Sleep(1000);


        }

        [Then(@"users is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {

            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));

            Admin.Click();
        }
        [Then(@"user is on home page and a error is dispalyed")]
        public void ThenUserIsOnHomePageAndAErrorIsDispalyed()
        {

            IWebElement forpasd = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p orangehrm-login-forgot-header']"));

            forpasd.Click();
            Console.WriteLine("error message");
        }

        [When(@"user enter the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string username, string password)
        {
            Console.WriteLine("The username is" + username + "password is" + password);
        }

        [When(@"user clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            Console.WriteLine("User clicks the login button");
        }

        [Then(@"users is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage1()
        {
            Console.WriteLine("User is on the home page");
        }

        [Then(@"user select city and country onformation")]
        public void ThenUserSelectsCityAndCountryOnformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine(city + "," + country);
            }
        }
    }
}

