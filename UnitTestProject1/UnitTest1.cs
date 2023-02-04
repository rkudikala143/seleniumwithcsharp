using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver _driver;

        [TestInitialize]
        public void Setup()
        {
            

            _driver = new ChromeDriver("@C:\\chrome\\chromedriver");
            _driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            _driver.Manage().Window.Maximize();

        }
        [TestCategory("Smoke")]
        [TestMethod]
        public void VerifyzRegisterPageTitle()
        {
            _driver.FindElement(By.ClassName("ico-register")).Click();
            NUnit.Framework.Assert.AreEqual(_driver.Title, "Demo Web Shop. Register");
        }

        [TestCategory("Regression")]
        [TestMethod]
        public void VerifyLoginPageTitle()
        {
            _driver.FindElement(By.ClassName("ico-login")).Click();
            NUnit.Framework.Assert.AreEqual(_driver.Title, "Demo Web Shop. Login");
        }
        [TestCategory("Functional")]
        [TestMethod]
        public void VerifyForgotPasswordTitle()
        {
            _driver.FindElement(By.ClassName("ico-login")).Click();
            NUnit.Framework.Assert.AreEqual(_driver.Title, "Demo Web Shop. Login");
        }

        [TestCategory("Smoke")]
        [TestMethod]
        public void VerifyHomePageTitle()
        {
            NUnit.Framework.Assert.AreEqual(_driver.Title, "Demo Webshop");
        }
        [TestCleanup]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
