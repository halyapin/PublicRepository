using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ZaebalTestom
{
    public class NavigationHelper:HelperBase
    {
        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
        this.baseURL = baseURL;
        }

    [TestFixture]
        public static class FirefoxInitialise
        {
            private static IWebDriver Driver { get; set; }
            public static IWebDriver Init()
            {
                // I'm assuming your geckodriver.exe is located there:
                // @"C:\MyGeckoDriverExePath\geckodriver.exe"
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe"; // May not be necessary
                FirefoxOptions options = new FirefoxOptions();
                TimeSpan time = TimeSpan.FromSeconds(10);
                Driver = new FirefoxDriver(service, options, time);
                return Driver;
            }
        }

        protected IWebDriver driver;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        protected bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";
            verificationErrors = new StringBuilder();
        }




        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost");
        }

        public void GoToGroupsPage()
        {
            //Go to gropups page
            driver.FindElement(By.LinkText("groups")).Click();
        }




    }
}
