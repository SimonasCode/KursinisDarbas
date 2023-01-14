using FrameWork;
using FrameWork.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class SkelbiuSvetaineTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            SkelbiuHomePage.Open();
        }

        [Test]
        public void CheckIfCookiesCanBeAccepted()
        {
            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            SkelbiuHomePage.WaitForCookiesModalNotToBeVisible();
        }

        [Test]
        public void CheckIfSearchReturnResults()
        {
            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            // Enter text to search and click Enter
            SkelbiuHomePage.SearchByPhrase("automobiliai");
            // Check if results shown matches search phrase
            Assert.AreEqual("automobiliai surasta šiose kategorijose", SkelbiuHomePage.GetSearchResultsText() + " surasta šiose kategorijose");
            SkelbiuHomePage.SearchByPhrase("butai");
            // Check if results shown matches search phrase
            Assert.AreEqual("butai surasta šiose kategorijose", SkelbiuHomePage.GetSearchResultsText() + " surasta šiose kategorijose");
        }

        [Test]
        public void LoginInWebsite()
        {
            string phoneNumber = "+37062578014";
            string password = "Ihateprogramming";

            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            // Click login button
            SkelbiuHomePage.ClickLoginButton();
            // Wait for the website to be loaded
            SkelbiuHomePage.WaitForElementToBeClickableAndClickOnLoginNameModal();
            // Enter username
            SkelbiuHomePage.EnterphoneNumber(phoneNumber);
            // Enter password
            SkelbiuHomePage.EnterPassword(password);
            // Click  button
            SkelbiuHomePage.ClickLoginInToAccountButton();

           // Assert.IsTrue(SkelbiuHomePage.IsUserLoggedIn(), "User is not logged in");
        }

        [Test]
        public void SearchByCategoryAnnouncement()
        {
            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            SkelbiuHomePage.ClickOnTransportSection();
            SkelbiuHomePage.ClickOnCarsButton();
            SkelbiuHomePage.ClickOnSubaruButton();
            SkelbiuHomePage.ClickOnBRZButton();
        }

        [Test]
        public void SearchByCategoryWithCriteria()
        {
            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            SkelbiuHomePage.ClickOnApartmentsOption();
            SkelbiuHomePage.ClickOnPriceFieldFrom();
            SkelbiuHomePage.ClickOnPriceFieldTo();
            SkelbiuHomePage.ClickChooseCityFromFilter();
            SkelbiuHomePage.

        }
      



        //[TearDown]
        //public void Teardown()
        //{
        //    Driver.CloseDriver();
        //}



    }
}
