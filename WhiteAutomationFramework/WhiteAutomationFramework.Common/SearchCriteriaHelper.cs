using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems.Finders;

namespace WhiteAutomationFramework.Common
{/// <summary>
/// This class is responsible for the different search criteria function.
/// </summary>
    class SearchCriteriaHelper
    {
        //Need To Modify This Area
        #region Search Criteria
        public static SearchCriteria searchByID(String id)
        {
            return SearchCriteria.ByAutomationId(id);
        }
        public static SearchCriteria searchByClassName(string name)
        {
            return SearchCriteria.ByClassName(name);
        }
        public static SearchCriteria searchByFramework(string framework)
        {
            return SearchCriteria.ByFramework(framework);
        }
        public static SearchCriteria searchByText(string text)
        {
            return SearchCriteria.ByText(text);
        }
        public static SearchCriteria searchByControlType(ControlType controlType)
        {
            return SearchCriteria.ByControlType(controlType);
        }
   
        #endregion
    }
}
