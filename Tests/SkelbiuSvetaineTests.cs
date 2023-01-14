using FrameWork;
using FrameWork.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
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



        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }



    }
}
