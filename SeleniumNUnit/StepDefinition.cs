using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumNUnit.StepDefinition
{
    [Binding]
    internal class StepDefinition
    {
        IWebDriver webDriver;


        [Given(@"User navigates to url ""([^""]*)""")]
        public void GivenUserNavigatesToUrl(string url)
        {
            webDriver = new ChromeDriver(@"D:\WebDriver\Chrome"); 
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(url);
        }

        [When(@"User input text ""([^""]*)"" on ""([^""]*)""")]
        public void WhenUserInputTextOn(string text, string identifier)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(identifier));
            webElement.SendKeys(text);
        }

        [When(@"User clicks on ""([^""]*)""")]
        public void WhenUserClicksOn(string identifier)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(identifier));
            webElement.Click();
        }

        [Then(@"User verify value of ""([^""]*)"" is ""([^""]*)""")]
        public void ThenUserVerifyValueOf(string identifier, string expectedvalue)
        {
            IWebElement webElement = webDriver.FindElement(By.XPath(identifier));
            Assert.That(webElement.Text, Is.EqualTo(expectedvalue));
        }


        [Then(@"User closes the browser")]
        public void ThenUserClosesTheBrowser()
        {
            webDriver.Close();
        }

    }
}
