using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using WhiteAutomationFramework.Driver;

namespace WhiteAutomationFramework.Common
{/// <summary>
/// This class will contain all the methods for interacting with the different element
/// of the application being tested.
/// </summary>
    public class WhiteHelper
    {
        #region ElementMethods
        //TextBox
        public static string returnText(TextBox textBox)
        {
            textBox.Text = "";
            return textBox.Text;
        }
        public static void enterTextBoxText(TextBox textbox, string text)
        {
            textbox.Text = text;
        }
        public static string getWindowTitle(Window window)
        {
            return window.Title;
        }
        public static string returnTextFromTextField(string id)
        {
            Label label = (Label)WindowDriver.Instance.Get(SearchCriteriaHelper.searchByID(id));
            return label.Text;
        }
        //Button
        public static Button getButton(String input)
        {
            return (Button)WindowDriver.Instance.Get(SearchCriteriaHelper.searchByText(input));
        }
        public static Menu getMenu(string input)
        {
            return (Menu)WindowDriver.Instance.Get(SearchCriteriaHelper.searchByText(input));
        }
        public static void buttonClick(Button button)
        {
            button.Click();
        }
        public static void menuClick(Menu menu)
        {
            menu.Click();
        }
        //CheckBox 
        public static bool checkBoxIsSelected(CheckBox checkBox)
        {
            return checkBox.IsSelected;
        }
        public bool isFocused(CheckBox checkBox)
        {
            return checkBox.IsFocussed;
        }
        //Label
        public static string returnLabelText(Label label)
        {
            return label.Text;
        }


        //Switching Windows
        public static Window switchWindow(string newWindowTitle)
        {
            return WindowDriver.switchWindow(newWindowTitle);

        }
        #endregion


    }
}
