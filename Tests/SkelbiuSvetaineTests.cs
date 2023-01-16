using FrameWork;
using FrameWork.POM;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Tests.BaseClasses;

namespace Tests
{
    internal class SkelbiuSvetaineTests : BaseTest
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
            SkelbiuHomePage.ClickToClosePostServices();
            Assert.AreEqual("Vartotojas: +37062578014", SkelbiuHomePage.LoggedInInfo());

        }

        [Test]
        public void SearchByCategoryAnnouncement()
        {
            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            SkelbiuHomePage.ClickOnTransportSection();
            SkelbiuHomePage.ClickOnCarsButton();
            SkelbiuHomePage.ClickOnSubaruButton();
            SkelbiuHomePage.ClickOnBRZButton();
            Assert.AreEqual("brz, subaru", SkelbiuHomePage.SearchSubaruList());
        }

        [Test]
        public void SearchByCategoryWithCriteria()
        {
            string priceFrom = "20000";
            string priceTo = "60000";

            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            SkelbiuHomePage.ClickOnApartmentsOption();
            SkelbiuHomePage.ClickOnPriceFieldFromAndEnterPrice(priceFrom);
            SkelbiuHomePage.ClickOnPriceFieldToAndEnterPrice(priceTo);
            SkelbiuHomePage.ClickChooseCityFromFilter();
            SkelbiuHomePage.ClickOnCity();
            SkelbiuHomePage.ClickOnSaveOptionField();
            SkelbiuHomePage.ClickMinRoomOption();
            SkelbiuHomePage.ClickMinRoomsButton();
            SkelbiuHomePage.ClickFiltrateButton();
            Assert.AreEqual("butai, kaunas, kaina, €: 20000 - 60000, kamb. sk.: nuo 2", SkelbiuHomePage.ApartmentsSearchResults());

        }

        [Test]
        public void CheckIfItWorksToReturnToPreviousPageFromWishListWihoutLoginToTheAccount()
        {
            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            SkelbiuHomePage.ClickOnComputersButton();
            SkelbiuHomePage.ClickOnHeartToRememberAnnouncement();
            SkelbiuHomePage.ClickToRememberedAnnouncements();
            SkelbiuHomePage.ClickReturnToThePreviousPage();
            SkelbiuHomePage.CheckIfAnnouncementListIsVisible();
        }

        [TearDown]
        public virtual void TearDown()
        {
            Driver.CloseDriver();
        }
    }    
}












//[TearDown]
//public virtual void TearDown()
//{
//    if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
//    {
//        Driver.TakeScreenshot(TestContext.CurrentContext.Test.FullName);
//    }
//    Driver.CloseDriver();
//}