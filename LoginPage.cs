using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Adactin_AndroidAutomation_Project.AdactinAndroid
{
    internal class LoginPage : CorePage
    {
        public void loginPage()
        {
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.XPath("//input[@id='username' and @type='text' and @name='username' and @class='login_input']")).SendKeys("samibaig16");
            driver.FindElement(By.XPath("//input[@id='password' and @type='password' and @name='password' and @class='login_input']")).SendKeys("08V0V7");
            driver.PressKeyCode(AndroidKeyCode.Keycode_TAB);
            driver.PressKeyCode(AndroidKeyCode.Enter);
            //driver.FindElement(By.XPath("//input[@id='login']")).Click();            
            
            //driver.FindElement(By.Id("login")).Click();
        }
    }
}
