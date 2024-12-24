using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
[assembly: Parallelizable(ParallelScope.All)]

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class ParellelExecutionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;

        public ParellelExecutionStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }

        [Given(@"user is on application page on IE browser")]
        public void GivenUserIsOnApplicationPageOnIEBrowser()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Console.WriteLine("User is on IE browser");
        }

        [Given(@"user is on application page on FF browser")]
        public void GivenUserIsOnApplicationPageOnFFBrowser()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Console.WriteLine("User is on FF browser");
        }

        [Given(@"user is on application page on Edge browser")]
        public void GivenUserIsOnApplicationPageOnEdgeBrowser()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Console.WriteLine("User is on Edge browser");
        }
    }
}





//using System;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IE;
//using TechTalk.SpecFlow;
//[assembly: Parallelizable(ParallelScope.All)]

//namespace SpecFlowProject2.StepDefinitions
//{
//    [Binding]
//    public class ParellelExecutionStepDefinitions
//    {
//        private readonly ScenarioContext _scenarioContext;
//        private IWebDriver _driver = null;

//        public ParellelExecutionStepDefinitions(ScenarioContext scenarioContext)
//        {

//            _scenarioContext = scenarioContext;
//            _driver = _scenarioContext["WebDriver"] as IWebDriver;

//        }
//        [Given(@"user is on application page on IE browser")]
//        public void GivenUserIsOnApplicationPageOnIEBrowser()
//        {
//            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);
//            Console.WriteLine("User is on IE browser");
//        }

//        [Given(@"user is on application page on FF browser")]
//        public void GivenUserIsOnApplicationPageOnFFBrowser()
//        {
//            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);
//            Console.WriteLine("User is on FF browser");
//        }

//        [Given(@"user is on application page on Edge browser")]
//        public void GivenUserIsOnApplicationPageOnEdgeBrowser()
//        {
//            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);
//            Console.WriteLine("User is on Edge browser");
//        }
//    }
//}