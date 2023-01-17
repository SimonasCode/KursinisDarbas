using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

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

        public static void TakeScreenshot(string testMethodName)
        {
            DateTime now = DateTime.Now;
            string formatedNowTime = now.ToString("yyyy-MM-dd-HH-mm-ss");
            string screenshotsDirectoryPath = $"C:/Users/PC/Pictures/TestResults/TestsTime-{formatedNowTime}";
            string screenshotName = $"{screenshotsDirectoryPath}\\{testMethodName}-.png";

            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }
    }
}