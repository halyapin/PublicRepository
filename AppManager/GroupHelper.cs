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
    public class GroupHelper:HelperBase
    {
        public GroupHelper (ApplicationManager manager): base(manager)
        {
         
        }

        public GroupHelper CreateGroup(GroupData group)
        {
            manager.Navigator.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            manager.Navigator.GoToGroupsPage();
            return this;
        }

        public void Modify(int p, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(p);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            manager.Navigator.GoToGroupsPage();

        }

        public void SubmitGroupModification()
        {
            throw new NotImplementedException();
        }

        public void InitGroupModification()
        {
            throw new NotImplementedException();
        }

        public GroupHelper InitGroupCreation()
        {
            //Init group creation
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + index + "]/input")).Click();
            return this;
        }
    

    public GroupHelper RemoveGroup()
    {
        driver.FindElement(By.Name("delete")).Click();
        return this;
     }


        public GroupHelper Remove(int p)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(1);
            RemoveGroup();
            manager.Navigator.GoToHomePage();
            return this;
        }
    public GroupHelper SubmitGroupCreation()
    {
        //Submit group creation
        driver.FindElement(By.Name("submit")).Click();
        return this;
    }

  
        public GroupHelper FillGroupForm(GroupData group)
    {
        //Fill group form
        driver.FindElement(By.Name("group_name")).Click();
        driver.FindElement(By.Name("group_name")).Clear();
        driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
        driver.FindElement(By.Name("group_header")).Click();
        driver.FindElement(By.Name("group_header")).Clear();
        driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
        driver.FindElement(By.Name("group_footer")).Click();
        driver.FindElement(By.Name("group_footer")).Clear();
        driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        return this;

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

    }

}
