using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_AndroidAutomation_Project.AdactinAndroid
{
    internal class BookingPage : CorePage
    {
        public void Bookingpage()
        {
            AndroidElement firstNameInput = driver.FindElement(By.XPath("//input[@name='first_name']"));
            AndroidElement lastNameInput = driver.FindElement(By.XPath("//input[@name='last_name']"));
            AndroidElement addressTextarea = driver.FindElement(By.XPath("//textarea[@name='address']"));
            AndroidElement ccNumInput = driver.FindElement(By.XPath("//input[@name='cc_num']"));

            // Send keys to the input fields
            firstNameInput.SendKeys("Sami");
            lastNameInput.SendKeys("Tester");
            addressTextarea.SendKeys("JoharBlock2");
            ccNumInput.SendKeys("1234567890123456");

            driver.FindElement(By.XPath("//select[@id='cc_type']")).SendKeys("VISA");

            // Select February from the dropdown
            driver.FindElement(By.XPath("//select[@id='cc_exp_month']")).SendKeys("February");

            // Select 2027 from the dropdown
            driver.FindElement(By.XPath("//select[@id='cc_exp_year']")).SendKeys("2027");

            // Enter CVV
            driver.FindElement(By.XPath("//input[@id='cc_cvv']")).SendKeys("415");

            // Click on the 'Book Now' button
            driver.PressKeyCode(AndroidKeyCode.Keycode_TAB);
            driver.PressKeyCode(AndroidKeyCode.Keycode_ENTER);
        }
    }
}
