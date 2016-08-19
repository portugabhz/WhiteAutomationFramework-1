using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WhiteAutomationFramework.Driver;
using WhiteAutomationFramework.PageObject;
using WhiteAutomationFramework.PageObject.Configuration;

namespace WhiteAutomationFramework.Specs.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void TestSetup()
        {
            TestBase.testSetup();
        }
        [AfterScenario]
        public void Teardown()
        {
            TestBase.tearDown();
        }
    }
}
