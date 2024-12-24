using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class OrangeTestparaStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;

        public OrangeTestparaStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
        {
            Console.WriteLine($"The username is {usrname}..... The password is {passwd}");
        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            Console.WriteLine("User clicked on submit button");
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("User is on the home page");
        }

        [Then(@"Users is on the home page and a error is displayed")]
        public void ThenUsersIsOnTheHomePageAndAnErrorIsDisplayed()
        {
            Console.WriteLine("Error displayed on the home page");
        }

        [Then(@"user selects city and country information")]
        public void ThenUserSelectsCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];
                Console.WriteLine($"City: {city}, Country: {country}");
            }
        }
    }
}



//using System;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using TechTalk.SpecFlow;

//namespace SpecFlowProject2.StepDefinitions
//{
//    [Binding]
//    public class OrangeTestparaStepDefinitions
//    {
//        private readonly ScenarioContext _scenarioContext;
//        private IWebDriver _driver;
//        public OrangeTestparaStepDefinitions(ScenarioContext scenarioContext)
//        {

//            _scenarioContext = scenarioContext;
//            _driver = _scenarioContext["WebDriver"] as IWebDriver;

//        }


//        [When(@"user enters the ""([^""]*)"" and ""([^""]*)""")]
//        public void WhenUserEntersTheAnd(string usrname, string passwd)
//        {
//            Console.WriteLine("The username is " + usrname + "....." + " The password is " + passwd);
//        }

//        [When(@"user clicks on login button")]
//        public void WhenUserClicksOnLoginButton()
//        {
//            Console.WriteLine("User clicked on login button");
//        }

//        [Then(@"users is navigated to home page")]
//        public void ThenUserIsNavigatedToHomePage()
//        {
//            Console.WriteLine("User is on the home page");
//        }

//        [Then(@"user selects city and country information")]
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



//        [When(@"user enters the ""([^""]*)"" and ""([^""]*)""")]
//        public void WhenUserEntersTheAnd(string usrname, string passwd)
//        {
//            throw new PendingStepException();
//        }

//        [When(@"user clicks on login button")]
//        public void WhenUserClicksOnLoginButton()
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"users is navigated to home page")]
//        public void ThenUsersIsNavigatedToHomePage()
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"user selects city and country information")]
//        public void ThenUserSelectsCityAndCountryInformation(Table table)
//        {
//            throw new PendingStepException();
//        }
//    }
//}
