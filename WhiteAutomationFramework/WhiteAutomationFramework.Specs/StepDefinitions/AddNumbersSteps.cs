using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WhiteAutomationFramework.Common;
using WhiteAutomationFramework.Driver;
using WhiteAutomationFramework.PageObject;

namespace WhiteAutomationFramework.Specs.StepDefinitions
{
    [Binding]
    public class AddNumbersSteps
    {
        [Given(@"the calculator application is open")]
        public void GivenTheCalculatorApplicationIsOpen()
        {
            Assert.AreEqual("Calculator", WhiteHelper.getWindowTitle(WindowDriver.Instance));
            Thread.Sleep(1000);
        }
        [When(@"I click button one")]
        public void WhenIClickButtonOne()
        {

            MainScreen.clickProgrammer();
            MainScreen.click1();
        }

        [When(@"I click plus")]
        public void WhenIClickPlus()
        {
            MainScreen.clickplus();
        }

        [When(@"I click button two")]
        public void WhenIClickButtonTwo()
        {
            MainScreen.click2();
        }

        [When(@"I click equals")]
        public void WhenIClickEquals()
        {
            MainScreen.clickEquals();
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string result)
        {
            Assert.AreEqual(result, MainScreen.verifyResult());
        }

    }
}