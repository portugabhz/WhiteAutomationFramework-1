using System;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using WhiteAutomationFramework.Common;
using WhiteAutomationFramework.Driver;

namespace WhiteAutomationFramework.PageObject
{
    public  class MainScreen 
    {
       public static Button addressButton { get { return WhiteHelper.getButton("Address Book"); } }

        public static void clickAddressButton()
        {
            WhiteHelper.buttonClick(addressButton);
        }

      
    }
}
