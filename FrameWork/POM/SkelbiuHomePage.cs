using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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



        //public static void OpenAndCloseCookies()
        //{
        //    Driver.OpenPage(url);
        //    Common.WaitAndClick(acceptCookiesLocator);
        //}

        // public static void () { }


        //public static void Click()
        //{
        //    //Driver.ClickServices(clickServicesButton);
        //    Common.ClickElement(clickServicesButton);

        //}


    }
}
