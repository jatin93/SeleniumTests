using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjects;

namespace UIAutomationTest;

public class LoginTest
{
    [Fact]
    public void ShouldBeAbleToLogin()
    {
        IWebDriver driver = new ChromeDriver();
        using var app = new App(driver);
        app.GetPage<LoginPage>().GoTo();
    }
}