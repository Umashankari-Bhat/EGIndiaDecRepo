﻿using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
using System.Security.Policy;

namespace SpecFlowProject2.hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;


        public Hooks(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;

        }


        [BeforeScenario]
        public void Setup()
        {

            Console.WriteLine("Running before every scenario");
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            IWebDriver driver = new FirefoxDriver();
            _scenarioContext["WebDriver"] = driver;
        }
        [AfterScenario]
        public void TearDown()
        {

            Console.WriteLine("Running after every scenario");
            var driver = _scenarioContext["WebDriver"] as IWebDriver;
            driver?.Dispose();
            driver?.Quit();


        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            TestContext.Progress.WriteLine("Running before TestRun");

        }


        [AfterTestRun]
        public static void AfterTestRun()
        {


            TestContext.Progress.WriteLine("Running after TestRun");


        }


        [BeforeStep]
        public void BeforeStep()
        {

            Console.WriteLine("Running before step");

        }


        [AfterStep]
        public void AfterStep()
        {

            Console.WriteLine("Running after step");

        }
        [BeforeScenario]
        public void BeforeScenario()
        {

            Console.WriteLine("Running before step");

        }


        [AfterScenario]
        public void AfterScenario()
        {

            Console.WriteLine("Running after step");

        }

    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;

//namespace SpecFlowProject2.Hooks
//{
//    internal class Hooks
//    {
//        private readonly ScenarioContext _scenarioContext;


//        public Hooks(ScenarioContext scenarioContext)
//        {

//            _scenarioContext = scenarioContext;

//        }


//        [BeforeScenario]
//        public void Setup()
//        {

//            Console.WriteLine("Running before every scenario");
//            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
//            IWebDriver driver = new FirefoxDriver();
//            _scenarioContext["WebDriver"] = driver;
//        }
//        [AfterScenario]
//        public void TearDown()
//        {

//            Console.WriteLine("Running after every scenario");
//            var driver = _scenarioContext["WebDriver"] as IWebDriver;
//            driver?.Quit();

//        }


//        [BeforeTestRun]
//        public static void BeforeTestRun()
//        {

//            TestContext.Progress.WriteLine("Running before TestRun");

//        }


//        [AfterTestRun]
//        public static void AfterTestRun()
//        {


//            TestContext.Progress.WriteLine("Running after TestRun");


//        }


//        [BeforeStep]
//        public void BeforeStep()
//        {

//            Console.WriteLine("Running before step");

//        }


//        [AfterStep]
//        public void AfterStep()
//        {

//            Console.WriteLine("Running after step");

//        }


//    }
//}
