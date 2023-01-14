using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork.POM
{
    public class SkelbiuHomePage
    {
        private static string url = "https://www.skelbiu.lt/";
        private static string cookiesAcceptButton = "//*[@id = 'onetrust-accept-btn-handler']";
        private static string cookiesModal = "//*[@id = 'onetrust-banner-sdk']";
        private static string searchField = "//*[@id = 'searchKeyword']";
        private static string searchResults = "//*[@id = 'popular_categories_title']/*";
        private static string loginButton = "//*[@id='mainTopMenu']/li[5]/a";
        private static string usernameModal = "//*[@id='nick-input']";
        private static string passwordModal = "//*[@id='password-input']";
        private static string loginInToAccount = "//*[@id='submit-button']";
        private static string transportButton = "//*[@id='transport']/a";
        private static string carsButton = "//*[@id='categoriesDiv']/div[1]/div[1]/a";
        private static string subaruButton = "//*[@id='categoriesDiv']/div[4]/div[5]/a";
        private static string BRZbutton = "//*[@id='categoriesDiv']/div[1]/div[3]/a";
        private static string apratments = "//*[@id='icon-41']/a";
        private static string priceFieldFrom = "//*[@id='costFromInput']";
        private static string priceFieldTo = "//*[@id='costTillInput']";
        private static string CityFilterButton = "//*[@id='chooseCitiesFromFilter']";
        private static string ChooseCity = "//*[@id='cityFor43']";
        //private static string clickServicesButton = "//*[@id='services']/a";
        //private static string clickWebSprendimai = "//*[@id'categoriesDiv']/div[3]/div[2]/a";
        //private static string ClickChangeLanguageButtonRu = "//*[@id='ru_lang']";


        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void WaitForElementToBeClickableAndClickAcceptCookiesButton()
        {
            Common.ClickElement(cookiesAcceptButton);
        }

        public static void WaitForCookiesModalNotToBeVisible()
        {
            Common.WaitForElementToBeInvisible(cookiesModal);
        }

        public static void SearchByPhrase(string text)
        {
            Common.EnterText(searchField, text);
            Common.ClickEnterButton(searchField);
        }

        public static void EnterTextToSeachField(string text)
        {
            Common.EnterText(searchField, text);
        }

        public static string GetSearchResultsText()
        {
            return Common.GetElement(searchResults).Text;
        }

        public static void ClickLoginButton()
        {
            Common.ClickElement(loginButton);
        }

        public static void WaitForElementToBeClickableAndClickOnLoginNameModal()
        {
            //Common.WaitForElementToBeClickableAndClickModal(usernameModal);
            Common.ClickElement(usernameModal);
        }

        public static void EnterphoneNumber(string phoneNumber)
        {
            Common.EnterText(usernameModal, phoneNumber);
        }

        public static void EnterPassword(string password)
        {
            Common.EnterText(passwordModal, password);
        }

        public static void ClickLoginInToAccountButton()
        {
            Common.ClickElement(loginInToAccount);
        }

        public static void ClickOnTransportSection()
        {
            Common.ClickElement(transportButton);
        }

        public static void ClickOnCarsButton()
        {
            Common.ClickElement(carsButton);
        }

        public static void ClickOnSubaruButton()
        {
            Common.ClickElement(subaruButton);
        }

        public static void ClickOnBRZButton()
        {
            Common.ClickElement(BRZbutton);
        }
    }
}
