using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_AndroidAutomation_Project.AdactinAndroid
{
    internal class SelectPage : CorePage
    {
        public void SelectHotel()
        {
            AndroidElement radioButton = driver.FindElement(By.XPath("//input[@name='radiobutton_0']"));

            radioButton.Click();

            AndroidElement continueButton = driver.FindElement(By.XPath("//input[@id='continue']"));
            continueButton.Click();
        }
    }

}
