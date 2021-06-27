using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuesser
{
    public class AppInfo
    {
        private static string _appName = "Number Guesser";
        private static string _appVersion = "1.0.0";
        private static string _appAuthor = "Alexander Ermilyev";

        public static void getAppInfo()
        {
            Helpers.PrintColorMessage(ConsoleColor.Green, $"{_appName}: Version {_appVersion} by {_appAuthor}");
        }
    }
}
