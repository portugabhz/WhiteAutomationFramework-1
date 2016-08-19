using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteAutomationFramework.Driver;
using WhiteAutomationFramework.PageObject.Configuration;

namespace WhiteAutomationFramework.PageObject
{
    public class TestBase
    {
        public static void testSetup()
        {
            WindowDriver.applicationPath = ApplicationSettings.GetApplicationPath();
            WindowDriver.applicationTitle = ApplicationSettings.getApplicationTitle;
            if (WindowDriver.window == null)
            {
                WindowDriver.grabWindow();

            }
        }
        public static void tearDown()
        {
            WindowDriver.closeApplication();
        }
    }
}
