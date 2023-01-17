using FrameWork;
using FrameWork.POM;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
            SkelbiuHomePage.SearchByPhrase("automobiliai");
            Assert.AreEqual("automobiliai surasta šiose kategorijose", SkelbiuHomePage.GetSearchResultsText() + " surasta šiose kategorijose");
            SkelbiuHomePage.SearchByPhrase("butai");
            Assert.AreEqual("butai surasta šiose kategorijose", SkelbiuHomePage.GetSearchResultsText() + " surasta šiose kategorijose");
        }

        [Test]
        public void LoginInWebsite()
        {
            string phoneNumber = "+37062578014";
            string password = "Ihateprogramming";

            SkelbiuHomePage.WaitForElementToBeClickableAndClickAcceptCookiesButton();
            SkelbiuHomePage.ClickLoginButton();
            SkelbiuHomePage.WaitForElementToBeClickableAndClickOnLoginNameModal();
            SkelbiuHomePage.EnterphoneNumber(phoneNumber);
            SkelbiuHomePage.EnterPassword(password);
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
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot(TestContext.CurrentContext.Test.FullName);
            }
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