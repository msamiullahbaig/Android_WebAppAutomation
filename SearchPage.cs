using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_AndroidAutomation_Project.AdactinAndroid
{
    internal class SearchPage : CorePage
    {
        public void SearchHotel()
        {
            // add a wait before interacting with the element
            
            driver.FindElement(By.XPath("//select[@id='location']")).SendKeys("Sydney");
            driver.FindElement(By.XPath("//select[@id='hotels']")).SendKeys("Hotel Hervey");
            driver.FindElement(By.XPath("//select[@id='room_type']")).SendKeys("Standard");
            driver.FindElement(By.XPath("//select[@id='room_nos']")).SendKeys("2 - Two");
            driver.FindElement(By.XPath("//input[@id='datepick_in']")).SendKeys("08/07/2021");
            driver.FindElement(By.XPath("//input[@id='datepick_out']")).SendKeys("09/07/2021");
            driver.FindElement(By.XPath("//select[@id='adult_room']")).SendKeys("2 - Two");
            driver.FindElement(By.XPath("//select[@id='child_room']")).SendKeys("2 - Two");
            driver.PressKeyCode(AndroidKeyCode.Keycode_TAB);
            driver.PressKeyCode(AndroidKeyCode.Keycode_ENTER);
            //// Perform a tap action
            //new TouchAction(driver).Tap(submitButton).Perform();
        }
    }
}
