using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrameWork
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            //configure options here
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void OpenPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}

//public class Driver
//{
//    public static void Initialize()
//    {
//        ChromeOptions options = new ChromeOptions();
//        //options.AddArgument("disable-notifications");
//        //options.AddArgument("start-maximized");
//        //options.AddArgument("headless");
//        //options.AddArgument("window-size=1920,1080");


//        //driver.Value = new ChromeDriver(options);
//    }

//    private static IWebDriver driver;

//    public static IWebDriver GetDtiver()
//    {
//        return driver;
//    }

//    public static void CreateDriver()
//    {
//        driver = new ChromeDriver();
//    }

//    public static void CloseDriver()
//    {
//        driver.Quit();
//    }

//    public static void OpenPage(string url)
//    {
//        driver.Navigate().GoToUrl(url);
//    }