using csharp_ecommerce_automation_framework.Utilities;
using NUnit.Framework;
using SauceDemoTests.Pages;
using SauceDemoTests.Utilities;

namespace SauceDemoTests.Tests
{
    public class ProductsTests : TestBase
    {
        [Test]
        public void AddProductToCartTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login(TestData.Username, TestData.Password);

            var productsPage = new ProductsPage(Driver);
            productsPage.AddFirstProductToCart();
            productsPage.OpenCart();

            Assert.That(Driver.Url, Is.EqualTo("https://www.saucedemo.com/cart.html"));
        }
    }
}
