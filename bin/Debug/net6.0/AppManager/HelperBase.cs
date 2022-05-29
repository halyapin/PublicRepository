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
    public class HelperBase
    {
        public IWebDriver driver;
        public ApplicationManager manager;
        public HelperBase(ApplicationManager manager) {
            this.manager = manager;
            driver = manager.Driver;
        }

    }
}