﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ZaebalTestom
{
    public class LoginHelper:HelperBase
    {


        public LoginHelper(ApplicationManager manager) : base(manager)
        {
        //this.driver = driver;

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


        public void Login(AccountData account)
        {
            //Login
            //driver.FindElement(By.Name("user")).Click();
            //driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            //driver.FindElement(By.Name("pass")).Click();
            //driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }



    }
}
