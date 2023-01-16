using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrameWork
{
    internal class Common
    {
        public static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        // WAITS
        internal static void WaitForElementToBeClickable(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        internal static void WaitForElementToBeInvisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            int seconds = 15;
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            }
            catch (WebDriverTimeoutException)
            {
                throw new NoSuchElementException(">>> Unable to locate element by '" + locator + "'! Waited for '" + seconds + "' seconds. <<<");
            }
            
        }

        // ACTIONS
        internal static void EnterText(string locator, string text)
        {
            // Getting element one time and assigning it to a variable solves the issue of looking for the same element multiple times (saves time, improves performance)
            IWebElement element = GetElement(locator); // Find element and keep it in memory
            WaitForElementToBeClickable(element); // Wait for element to be clickable (using the element from memory)
            element.Click(); // Click element (using the element from memory)
            element.Clear(); // Clear information from it if it exists (using the element from memory)
            element.SendKeys(text); // Send keys (text) to the element (using the element from memory)
        }

        internal static void ClickElement(string locator)
        {
            IWebElement element = GetElement(locator);
            WaitForElementToBeClickable(element);
            element.Click();
        }

        internal static void ClickEnterButton(string locator)
        {
            IWebElement element = GetElement(locator);
            element.SendKeys(Keys.Enter);
        }
    }
}