using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlow_GithubActions.Drivers
{
    internal class Driver
    {
        private static List<IWebDriver> _iWebDrivers = new List<IWebDriver>();        

        public static IWebDriver GetDriver(int index = 0)
        {
            if (Driver._iWebDrivers.ElementAtOrDefault<IWebDriver>(index) == null)
            {                
                Driver._iWebDrivers.Insert(index, (IWebDriver)new ChromeDriver(@"../../../" + "Drivers/"));
            }
            return Driver._iWebDrivers[index];
        }
        public static void CloseDriver()
        {
            for (int index = 0; index < Driver._iWebDrivers.Count; ++index)
            {
                if (Driver._iWebDrivers[index] != null)
                {
                    Driver._iWebDrivers[index].Quit();
                }
            }
        }
    }
}
