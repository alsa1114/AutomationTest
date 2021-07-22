using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationtTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            webDriver.Manage().Window.Maximize();


            IWebElement lkLogin = webDriver.FindElement(By.LinkText("Login"));
            lkLogin.Click();
           

            var txtInLogin = webDriver.FindElement(By.Name("UserName"));
            txtInLogin.SendKeys("admin");

            var txtInPass = webDriver.FindElement(By.Name("Password"));
            txtInPass.SendKeys("password");


            Assert.Pass();
        }
    }
}