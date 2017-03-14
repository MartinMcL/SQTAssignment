using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Test1
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:64706/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
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
        
        [Test]
        public void Male18Test()
        {
            driver.Navigate().GoToUrl(baseURL + "Default");
            driver.FindElement(By.Id("MainContent_genderTxt")).Clear();
            driver.FindElement(By.Id("MainContent_genderTxt")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_AgeTxt")).Clear();
            driver.FindElement(By.Id("MainContent_AgeTxt")).SendKeys("18");
            driver.FindElement(By.Id("MainContent_SubmitBtn")).Click();
            System.Threading.Thread.Sleep(750);
            Assert.That(driver.FindElement(By.Id("MainContent_PremiumLbl")).Text == "6");
        }
        [Test]
        public void Female18Test()
        {
            driver.Navigate().GoToUrl(baseURL + "Default");
            driver.FindElement(By.Id("MainContent_genderTxt")).Clear();
            driver.FindElement(By.Id("MainContent_genderTxt")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_AgeTxt")).Clear();
            driver.FindElement(By.Id("MainContent_AgeTxt")).SendKeys("18");
            driver.FindElement(By.Id("MainContent_SubmitBtn")).Click();
            System.Threading.Thread.Sleep(750);
            Assert.That(driver.FindElement(By.Id("MainContent_PremiumLbl")).Text == "5");
        }
        [Test]
        public void Male43Test()
        {
            driver.Navigate().GoToUrl(baseURL + "Default");
            driver.FindElement(By.Id("MainContent_genderTxt")).Clear();
            driver.FindElement(By.Id("MainContent_genderTxt")).SendKeys("male");
            driver.FindElement(By.Id("MainContent_AgeTxt")).Clear();
            driver.FindElement(By.Id("MainContent_AgeTxt")).SendKeys("43");
            driver.FindElement(By.Id("MainContent_SubmitBtn")).Click();
            System.Threading.Thread.Sleep(750);
            Assert.That(driver.FindElement(By.Id("MainContent_PremiumLbl")).Text == "5");
        }
        [Test]
        public void Female38Test()
        {
            driver.Navigate().GoToUrl(baseURL + "Default");
            driver.FindElement(By.Id("MainContent_genderTxt")).Clear();
            driver.FindElement(By.Id("MainContent_genderTxt")).SendKeys("female");
            driver.FindElement(By.Id("MainContent_AgeTxt")).Clear();
            driver.FindElement(By.Id("MainContent_AgeTxt")).SendKeys("38");
            driver.FindElement(By.Id("MainContent_SubmitBtn")).Click();
            System.Threading.Thread.Sleep(750);
            Assert.That(driver.FindElement(By.Id("MainContent_PremiumLbl")).Text == "2.5");

        }
        [Test]
        public void Xyz18Test()
        {
            driver.Navigate().GoToUrl(baseURL + "Default");
            driver.FindElement(By.Id("MainContent_genderTxt")).Clear();
            driver.FindElement(By.Id("MainContent_genderTxt")).SendKeys("xyz");
            driver.FindElement(By.Id("MainContent_AgeTxt")).Clear();
            driver.FindElement(By.Id("MainContent_AgeTxt")).SendKeys("18");
            driver.FindElement(By.Id("MainContent_SubmitBtn")).Click();
            System.Threading.Thread.Sleep(750);
            Assert.That(driver.FindElement(By.Id("MainContent_PremiumLbl")).Text == "0");
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
