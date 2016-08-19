using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using WhiteAutomationFramework.Driver;

namespace WhiteAutomationFramework.Common
{
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
        //Button
        public static Button getButton(String id)
        {
            return  (Button)WindowDriver.Instance.Get(SearchCriteria.ByText(id));
        }
        public static void buttonClick(Button button)
        {
            button.Click();
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
        #endregion

        #region Search Criteria
        public static SearchCriteria searchByID(String id)
        {
            return SearchCriteria.ByAutomationId(id);
        }
        #endregion

    }
}
