using System;
using System.Runtime.CompilerServices;
using Riganti.Selenium.AssertApi;
using Riganti.Selenium.Core;
using Riganti.Selenium.Core.Abstractions;

namespace DotVVM.Contrib.Tests2
{
    public class AppSeleniumTest : SeleniumTest
    {
        public void Run(Action<IBrowserWrapper> testBody, [CallerMemberName] string callerMemberName = "",
            [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = 0)
        {
            this.RunInAllBrowsers(testBody, callerMemberName, callerFilePath, callerLineNumber);
        }


    }
}