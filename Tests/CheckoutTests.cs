using csharp_ecommerce_automation_framework.Utilities;
using NUnit.Framework;
using SauceDemoTests.Pages;
using SauceDemoTests.Utilities;

namespace SauceDemoTests.Tests
{
    public class CheckoutTests : TestBase
    {
        [Test]
        public void CompleteCheckoutTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login(TestData.Username, TestData.Password);

            var productsPage = new ProductsPage(Driver);
            productsPage.AddFirstProductToCart();
            productsPage.OpenCart();

            var cartPage = new CartPage(Driver);
            cartPage.Checkout();

            var checkoutPage = new CheckoutPage(Driver);
            checkoutPage.EnterCheckoutInformation("John", "Doe", "12345");
            checkoutPage.FinishCheckout();

            Assert.That(Driver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-complete.html"));
        }
    }
}
