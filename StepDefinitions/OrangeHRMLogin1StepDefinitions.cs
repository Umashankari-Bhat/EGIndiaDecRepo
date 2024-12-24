using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class OrangeHRMLogin1StepDefinitions
    {
            private readonly ScenarioContext _scenarioContext;
            private IWebDriver _driver = null;

        public OrangeHRMLogin1StepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
            Thread.Sleep(1000);
        }
        [Given(@"User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            _driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [When(@"User enters the Username and Password")]
        public void WhenUserEntersTheUsernameAndPassword()
        {
            //throw new PendingStepException();
            IWebElement username = _driver.FindElement(By.XPath("//input[@name='username']"));
            username.SendKeys("Admin");
            IWebElement password = _driver.FindElement(By.XPath("//input[@name='password']"));
            username.SendKeys("admin123");
        }

        [When(@"User clicks on login butn")]
        public void WhenUserClicksOnLoginButn()
        {
            IWebElement Login = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            Login.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is navigated to home pg")]
        public void ThenUserIsNavigatedToHomePg()
        {
            Console.WriteLine("Entered to home page");
        }
   

//[When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
//            public void WhenUserEntersTheAnd(string usrname, string passwd)
//            {
//                Console.WriteLine("The username is " + usrname + "....." + " The password is " + passwd);
//                Thread.Sleep(1000);
//        }

            [When(@"User clicks on login button")]
            public void WhenUserClicksOnLoginButton()
            {
                Console.WriteLine("User clicked on login button");
                Thread.Sleep(1000);
        }

            [Then(@"user is navigated to home page")]
            public void ThenUserIsNavigatedToHomePage()
            {
                Console.WriteLine("User is on the home page");
            Thread.Sleep(1000);
        }

            [Then(@"User selects city and country information")]
            public void ThenUserSelectsCityAndCountryInformation(Table table)
            {
                foreach (var row in table.Rows)
                {
                    string city = row["city"];
                    string country = row["country"];
                    Console.WriteLine(city + " , " + country);
                Thread.Sleep(1000);
            }
            }
        }
}

