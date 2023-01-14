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
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        // ACTIONS
        internal static void EnterText(string locator, string text)
        {
            // Getting element one time and assigning it to a variable solves the issue of looking for the same element multiple times (saves time, improves performance)
            IWebElement element = GetElement(locator);
            WaitForElementToBeClickable(element);
            element.Click();
            element.Clear();
            element.SendKeys(text);
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

        //internal static void EnterPassword(string locator, string password)
        //{
        //    IWebElement element = GetElement(locator);
        //    WaitForElementToBeClickable(element);
        //    element.Click();
        //   // element.SendKeys(password);
        //}
    }
}