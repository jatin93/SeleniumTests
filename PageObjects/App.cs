using OpenQA.Selenium;

namespace PageObjects;

public class App : IDisposable
{
    public readonly LoginPage _loginpage;
    private IWebDriver  Driver {  get; }


    public App(IWebDriver driver)
    {
        Driver = driver;
    }

    public void Dispose()
    {
        Driver.Quit();
    }

    public T GetPage<T>() where T : IPage
    {
        T page = (T)Activator.CreateInstance(typeof(T), Driver);
        return page;
    }

}