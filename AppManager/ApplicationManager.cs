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
    public class ApplicationManager
    {


        public IWebDriver driver;
        public StringBuilder verificationErrors;
        public string baseURL;
        public bool acceptNextAlert = true;

        public LoginHelper loginHelper ;
        public NavigationHelper navigator;
        public GroupHelper groupHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            verificationErrors = new StringBuilder();

            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);

        }


        public IWebDriver Driver 
        {
            get 
            {
                return driver;
            }
        }



        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        
        }




        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }

        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }

        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }

        }

    }

}
