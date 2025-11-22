// This class is now redundant due to improved TestBase. Recommend removing usages and deleting this file.

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverSetup
{
    protected IWebDriver driver;

    public void Initialize()
    {
        driver = new ChromeDriver(); // Initialize ChromeDriver
        driver.Manage().Window.Maximize();
    }

    public void Cleanup()
    {
        driver.Quit(); // Close and quit the browser
    }
}