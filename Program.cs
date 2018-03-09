using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            Properties.driver = new ChromeDriver();
            Properties.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Test]
        public void ExecuteTest()
        {
            //Login to app
            LoginPageObject pageLogin = new LoginPageObject();
            PageObject page = pageLogin.Login("execute", "automation");

            page.FillUserForm("T", "Michael", "Lantz");
            
        }

        [TearDown]
        public void Cleanup()
        {
            Properties.driver.Quit();      
        }

    }
}
