using NUnit.Framework;
using SauceDemoTests.Pages;
using csharp_ecommerce_automation_framework.Utilities;
using SauceDemoTests.Utilities;

namespace csharp_ecommerce_automation_framework.Tests
{
    public class AuthenticationTests : TestBase
    {
        [Test]
        public void ValidLoginTest()
        {
            var loginPage = new LoginPage(Driver!);
            loginPage.Login(TestData.Username, TestData.Password);

            Assert.That(Driver!.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Test]
        public void InvalidLoginTest()
        {
            var loginPage = new LoginPage(Driver!);
            loginPage.Login("invalidUser", "invalidPass");

            Assert.That(Driver!.Url, Is.EqualTo("https://www.saucedemo.com/")); // Should remain on login page
            // Optionally, assert error message is displayed
        }
    }
}
