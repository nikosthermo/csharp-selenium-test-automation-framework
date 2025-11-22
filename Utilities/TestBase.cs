using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace csharp_ecommerce_automation_framework.Utilities
{
    public class TestBase
    {
        protected IWebDriver? Driver;

        [SetUp]
        public void Setup()
        {
            try
            {
                var options = new ChromeOptions();
                options.AddArgument("--disable-features=PasswordCheck,PasswordLeakDetection");
                options.AddArgument("--disable-popup-blocking");
                options.AddArgument("--no-default-browser-check");
                Driver = new ChromeDriver(options);
                Driver.Manage().Window.Maximize();
                Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            }
            catch (Exception ex)
            {
                Assert.Fail($"WebDriver initialization failed: {ex.Message}");
            }
        }

        [TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}
