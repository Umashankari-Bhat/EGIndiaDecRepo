using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class XYZBankNewStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XYZBankNewStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@": User in on login page")]
        public void GivenUserInOnLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"Customer clicks on Customer Login button")]
        public void WhenCustomerClicksOnButton()
        {
            IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']")); //button[normalize-space()='Customer Login']
            CustLogin.Click();
            Thread.Sleep(2000);
        }

        [When(@"selects the name")]
        public void WhenSelectsTheName()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("(//select[@id='userSelect'])[1]")); //select[@id='userSelect']
            NamesDropDown.Click();
            var select = new SelectElement(NamesDropDown);
            Thread.Sleep(2000);
            //select by value
            select.SelectByText("Harry Potter");
            Thread.Sleep(2000);
        }

        [When(@"User Clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            NamesDropDown.Click();
        }

        [Then(@"User is logged in and can see data")]
        public void ThenUserIsLoggedInAndCanSeeData()
        {
            Console.WriteLine("Customer Logged In");
        }
    }
}


//using System;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium;
//using TechTalk.SpecFlow;

//namespace SpecFlowProject2.StepDefinitions
//{
//    [Binding]
//    public class XYZBankNewStepDefinitions
//    {
//        private ScenarioContext _scenarioContext;
//        private IWebDriver _driver;

//        public XYZBankNewStepDefinitions(ScenarioContext scenarioContext)
//        {
//            _scenarioContext = scenarioContext;
//            _driver = _scenarioContext["WebDriver"] as IWebDriver;
//        }

//        [Given(@": User in on login page")]
//        public void GivenUserInOnLoginPage()
//        {
//            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000); // Retain your original method for simplicity
//        }

//        [When(@"Customer clicks on Customer Login button")]
//        public void WhenCustomerClicksOnButton()
//        {
//            IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
//            CustLogin.Click();
//        }

//        [When(@"selects the name")]
//        public void WhenSelectsTheName()
//        {
//            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']")); // Keep your original XPath
//            NamesDropDown.Click();
//            var select = new SelectElement(NamesDropDown);

//            // Small wait to ensure dropdown is interactable
//            Thread.Sleep(1000);
//            select.SelectByText("Harry Potter");

//            // Small wait after selection
//            Thread.Sleep(1000);
//        }

//        [When(@"User Clicks on login button")]
//        public void WhenUserClicksOnLoginButton()
//        {
//            IWebElement LoginButton = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
//            LoginButton.Click();
//        }

//        [Then(@"User is logged in and can see data")]
//        public void ThenUserIsLoggedInAndCanSeeData()
//        {
//            Console.WriteLine("Customer Logged In");

//            // Optionally, verify successful login
//            IWebElement WelcomeText = _driver.FindElement(By.XPath("//span[contains(text(),'Harry Potter')]")); // Adjust XPath as needed
//            Console.WriteLine("Logged In User: " + WelcomeText.Text);
//        }
//    }
//}




/*using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class XYZBankNewStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XYZBankNewStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@": User in on login page")]
        public void GivenUserInOnLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"Customer clicks on Customer Login button")]
        public void WhenCustomerClicksOnButton()
        {
            IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
            CustLogin.Click();
        }

        [When(@"selects the name")]
        public void WhenSelectsTheName()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']")); //select[@id='userSelect']
            NamesDropDown.Click();
            var select = new SelectElement(NamesDropDown);
            Thread.Sleep(2000);
            //select by value
            select.SelectByText("Harry Potter");
            Thread.Sleep(2000);
        }

        [When(@"User Clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            NamesDropDown.Click();
        }

        [Then(@"User is logged in and can see data")]
        public void ThenUserIsLoggedInAndCanSeeData()
        {
            Console.WriteLine("Customer Logged In");
        }
    }
}*/