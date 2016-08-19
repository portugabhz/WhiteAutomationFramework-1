using System;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace WhiteAutomationFramework.Driver
{
    public static class WindowDriver
    {
        public static Window window;
        public static Application application;
        public static string applicationPath { get; set; }
        public static string applicationTitle { get; set; }

        public static Window Instance
        {
            get { return window ?? (window = grabWindow()); }
        }


        public static Window grabWindow()
        {
            application = Application.Launch(applicationPath);
            window = application.GetWindow(applicationTitle);
            return window;
        }

        public static void closeApplication()
        {
            if (application != null) application.Close();
        }

    }
}
