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
    public class MainScreen
    {
        public static Button one { get { return WhiteHelper.getButton("1"); } }
        public static Button two { get { return WhiteHelper.getButton("2"); } }
        public static Button plus { get { return WhiteHelper.getButton("+"); } }
        public static Button equal { get { return WhiteHelper.getButton("="); } }
        public static string result { get { return WhiteHelper.returnTextFromTextField("150"); } }

        public static Menu mode { get { return WhiteHelper.getMenu("Mode"); } }
        public static Menu programmer { get { return WhiteHelper.getMenu("Programmer"); } }


        public static void click1()
        {
            WhiteHelper.buttonClick(one);
        }
        public static void click2()
        {
            WhiteHelper.buttonClick(two);
        }
        public static void clickplus()
        {
            WhiteHelper.buttonClick(plus);
        }
        public static void clickEquals()
        {
            WhiteHelper.buttonClick(equal);
        }
        public static string verifyResult()
        {
            return result;
        }
        public static void clickProgrammer()
        {
            WhiteHelper.menuClick(mode);
            WhiteHelper.menuClick(programmer);
        }
    }
}
