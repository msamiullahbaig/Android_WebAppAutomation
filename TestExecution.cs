using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Adactin_AndroidAutomation_Project.AdactinAndroid;

namespace Adactin_AndroidAutomation_Project
{
    public class TestExecution
    {



        [SetUp]
        public void BeforeEachTest()
        {
            CorePage.InitializeDriver();
        }

        [TearDown]
        
        public void AfterEachTest()
        {
            CorePage.driver.CloseApp();
        }
        LoginPage loginpagee = new LoginPage();
        SearchPage searchpagee = new SearchPage();
        SelectPage selectpagee = new SelectPage();
        BookingPage bookingpagee = new BookingPage();
        [Test]
        public void Android_Web_App()
        {
            loginpagee.loginPage();
            searchpagee.SearchHotel();
            selectpagee.SelectHotel();
            bookingpagee.Bookingpage();
        }
    }
}