using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using static TestStack.White.WindowsAPI.KeyboardInput;

namespace WhiteAutomationFramework.Common.Helper
{
    class WhiteHelper
    {
        #region Element Methods
        public static string returnText(TextBox textBox)
        {
            try
            {
                return textBox.Text;
            }catch (Exception)
            {
                return string.Empty;
            }
        }
        public static void clickButton(UIItem button)
        {
            button.Click();
            TextBox text = null;
            
           
        }
       
        #endregion
    }
}
