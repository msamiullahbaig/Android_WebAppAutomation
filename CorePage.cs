using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;

namespace Adactin_AndroidAutomation_Project
{
    public class CorePage
    {
        public static AndroidDriver<AndroidElement> driver;

        public static void InitializeDriver()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("deviceName", "Enter Your DeviceName");
            options.AddAdditionalCapability("platformVersion", "12.0");
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("udid", "Enter Your Device ADB CODE");
            options.AddAdditionalCapability("browserName", "chrome");

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.GetMergeResult(chromeOptions);
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);
        }
    }
}
