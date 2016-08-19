using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestStack.White.UIItems.WindowItems;
using WhiteAutomationFramework.Common;
using WhiteAutomationFramework.Driver;
using WhiteAutomationFramework.PageObject;

namespace WhiteAutomationFramework.Specs.StepDefinitions
{
    [Binding]
    public class BlahSteps
    {
        Window window = WindowDriver.Instance;
        [Given(@"that thunderbird is open")]
        public void GivenThatThunderbirdIsOpen()
        {
            Assert.AreEqual("Inbox - Work - Mozilla Thunderbird", WhiteHelper.getWindowTitle(window));
        }
        
        [Given(@"then i click address book")]
        public void GivenThenIClickAddressBook()
        {
            MainScreen.clickAddressButton();   
        }
        
        [Then(@"the addres book should be displayed")]
        public void ThenTheAddresBookShouldBeDisplayed()
        {
            WhiteHelper.switchWindow("Address Book");
            Assert.AreEqual("Address Book",WhiteHelper.getWindowTitle(WindowDriver.Instance));
        }
    }
}
