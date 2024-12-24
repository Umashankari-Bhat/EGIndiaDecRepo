

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;

        public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }


        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {


            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
        {

            IWebElement username = _driver.FindElement(By.XPath("//input[@name = 'username']"));

            username.SendKeys(usrname);


            IWebElement password = _driver.FindElement(By.XPath("//input[@name = 'password']"));

            password.SendKeys(passwd);
            Thread.Sleep(1000);


        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {


            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

            loginbutton.Click();

            Thread.Sleep(1000);


        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {

            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));

            Admin.Click();
            Thread.Sleep(1000);

        }
        [Then(@"User is on the home page and a error is displayed")]
        public void ThenUserIsOnHomePageAndAErrorIsDispalyed()
        {

            IWebElement forpasd = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p orangehrm-login-forgot-header']"));

            forpasd.Click();
            Console.WriteLine("error message");
            Thread.Sleep(1000);
        }
    }
}


//        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
//        public void WhenUserEntersTheAnd(string usrname, string passwd)
//        {
//            Console.WriteLine("The username is " + usrname + "....." + " The password is " + passwd);
//        }

//        [When(@"User clicks on login button")]
//        public void WhenUserClicksOnLoginButton()
//        {
//            Console.WriteLine("User clicked on login button");
//        }

//        [Then(@"user is navigates to home page")]
//        public void ThenUserIsNavigatedToHomePage()
//        {
//            Console.WriteLine("User is on the home page");
//        }

//        [Then(@"User selects city and country information")]
//        public void ThenUserSelectsCityAndCountryInformation(Table table)
//        {
//            foreach (var row in table.Rows)
//            {
//                string city = row["city"];
//                string country = row["country"];
//                Console.WriteLine(city + " , " + country);
//            }
//        }
//    }
//}



//using System;
//using OpenQA.Selenium;
//using TechTalk.SpecFlow;

//namespace SpecFlowProject2.StepDefinitions
//{
//    [Binding]
//    public class OrangeHRMStepDefinitions
//    {
//        private readonly ScenarioContext _scenarioContext;
//        private IWebDriver _driver = null;

//        public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
//        {
//            _scenarioContext = scenarioContext;
//            _driver = _scenarioContext["WebDriver"] as IWebDriver;
//        }

//        [Given(@"User is on the orange hrm login page")]
//        public void GivenUserIsOnTheOrangeHrmLoginPage()
//        {
//            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);  // Sleep added for page load - consider replacing with WebDriverWait in real use cases
//        }

//        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
//        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
//        {
//            IWebElement username = _driver.FindElement(By.XPath("//input[@name = 'username']"));
//            username.SendKeys(usrname);

//            IWebElement password = _driver.FindElement(By.XPath("//input[@name = 'password']"));
//            password.SendKeys(passwd);
//        }

//        [When(@"User clicks on submit button")]
//        public void WhenUserClicksOnSubmitButton()
//        {
//            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));
//            loginbutton.Click();
//            Thread.Sleep(1000);  // Sleep added for page load - consider replacing with WebDriverWait in real use cases
//        }

//        [Then(@"User is navigated to home page")]
//        public void ThenUserIsNavigatedToHomePage()
//        {
//            // Verify that the Admin menu is displayed after a successful login
//            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));
//            if (Admin.Displayed)
//            {
//                Console.WriteLine("User is successfully navigated to home page.");
//                Admin.Click();
//            }
//            else
//            {
//                Console.WriteLine("Admin menu is not displayed. Navigation to home page failed.");
//            }
//        }

//        [Then(@"User is on the home page and a error is displayed")]
//        public void ThenUserIsOnHomePageAndAErrorIsDispalyed()
//        {
//            // Check if the error message for invalid credentials is displayed
//            IWebElement errorMessage = _driver.FindElement(By.XPath("//p[contains(text(), 'Invalid credentials')]"));
//            if (errorMessage.Displayed)
//            {
//                Console.WriteLine("Error message for invalid credentials is displayed.");
//            }
//            else
//            {
//                Console.WriteLine("Error message for invalid credentials is not displayed.");
//            }
//        }
//    }
//}











//using System;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using TechTalk.SpecFlow;

//namespace SpecFlowProject2.StepDefinitions
//{
//    [Binding]
//    public class OrangeHRMStepDefinitions
//    {
//        private readonly ScenarioContext _scenarioContext;
//        private IWebDriver _driver = null;

//        public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
//        {

//            _scenarioContext = scenarioContext;
//            _driver = _scenarioContext["WebDriver"] as IWebDriver;

//        }


//        [Given(@"User is on the orange hrm login page")]
//        public void GivenUserIsOnTheOrangeHrmLoginPage()
//        {


//            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);
//        }

//        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
//        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
//        {

//            IWebElement username = _driver.FindElement(By.XPath("//input[@name = 'username']"));

//            username.SendKeys(usrname);


//            IWebElement password = _driver.FindElement(By.XPath("//input[@name = 'password']"));

//            password.SendKeys(passwd);


//        }

//        [When(@"User clicks on submit button")]
//        public void WhenUserClicksOnSubmitButton()
//        {


//            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

//            loginbutton.Click();

//            Thread.Sleep(1000);


//        }

//        [Then(@"User is navigated to home page")]
//        public void ThenUserIsNavigatedToHomePage()
//        {

//            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));

//            Admin.Click();
//        }
//        [Then(@"User is navigated to home page and error is displayed")]
//        public void ThenUserIsOnHomePageAndAErrorIsDispalyed()
//        {

//            IWebElement forpasd = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p orangehrm-login-forgot-header']"));

//            forpasd.Click();
//            Console.WriteLine("error message");
//        }
//    }
//}

//private readonly ScenarioContext _scenarioContext;
//private IWebDriver _driver;

//public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
//{

//    _scenarioContext = scenarioContext;
//    _driver = _scenarioContext["WebDriver"] as IWebDriver;

//}


//[Given(@"User is on the orange hrm login page")]
//public void GivenUserIsOnTheOrangeHrmLoginPage()
//{


//    _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
//    _driver.Manage().Window.Maximize();
//    Thread.Sleep(2000);
//}

//[When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
//public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
//{

//    IWebElement username = _driver.FindElement(By.XPath("//input[@name = 'username']"));

//    username.SendKeys(usrname);


//    IWebElement password = _driver.FindElement(By.XPath("//input[@name = 'password']"));

//    password.SendKeys(passwd);


//}

//[When(@"User clicks on submit button")]
//public void WhenUserClicksOnSubmitButton()
//{


//    IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

//    loginbutton.Click();

//    Thread.Sleep(1000);


//}

//[Then(@"User is navigated to home page")]
//public void ThenUserIsNavigatedToHomePage()
//{

//    IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));

//    Admin.Click();
//}
//[Then(@"User is navigated to home page and error is displayed")]
//public void ThenUserIsOnHomePageAndAErrorIsDispalyed()
//{

//    IWebElement forpasd = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p orangehrm-login-forgot-header']"));

//    forpasd.Click();
//    Console.WriteLine("error is displayed");
//}
//        //[Then(@"User is navigated to home page and error is displayed")]
//        //public void ThenUserIsNavigatedToHomePageAndErrorIsDisplayed()
//        //{
//        //    Console.WriteLine("error is displayed");
//        //}
//    }

//}



