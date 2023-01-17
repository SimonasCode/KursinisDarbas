namespace FrameWork.POM
{
    public class SkelbiuHomePage
    {
        private static string url = "https://www.skelbiu.lt/";
        private static string cookiesAcceptButton = "//*[@id = 'onetrust-accept-btn-handler']";
        private static string cookiesModal = "//*[@id = 'onetrust-banner-sdk']";
        private static string searchField = "//*[@id = 'searchKeyword']";
        private static string searchResults = "//*[@id = 'popular_categories_title']/*";
        private static string loginButton = "//ul[@id='mainTopMenu']//a[@href='/users/signin']";
        private static string usernameModal = "//*[@id='nick-input']";
        private static string passwordModal = "//*[@id='password-input']";
        private static string loginInToAccount = "//*[@id='submit-button']";
        private static string closePostPopUp = "//*[@id = 'omniva-notification-container']//div[@class = 'close-button']//img";
        private static string checkIfLoggedIn = "//*[@id='header-username']";
        private static string transportButton = "//*[@id='transport']/a";
        private static string carsButton = "//div[@id='categoriesDiv']//a[text()='Automobiliai']";
        private static string subaruButton = "//*[@id='categoriesDiv']//div[@class='categoriesList']//a[@href='/skelbimai/transportas/automobiliai/subaru/']";
        private static string BRZbutton = "//div[@id='categoriesDiv']//a[text()='BRZ']";
        private static string BRZList = "//div[@class='list-header']//p";
        private static string apartments = "//*[@id='icon-41']/a";
        private static string priceFieldFrom = "//*[@id='costFromInput']";
        private static string priceFieldTo = "//*[@id='costTillInput']";
        private static string CityFilterButton = "//*[@id='chooseCitiesFromFilter']";
        private static string ChooseCity = "//*[@id='cityFor43']";
        private static string saveOptionButton = "//*[@id='addCitiesButton']";
        private static string minRoomOption = "//div[@class='filter']//select[@name='rooms_min']";
        private static string minRooms = "//div[@class='filter']//select[@name='rooms_min']//option[@value='2']";
        private static string filtrateButton = "//div[@class='filter']//button";
        private static string apartmentsListByFilter = "//div[@class='list-header']//p";
        private static string computerButton = "//*[@id='icon-79']//a[@href='/skelbimai/kompiuterija/kompiuteriai/']";
        private static string rememberButton = "//div[@class='remember-button remember rounded']";
        private static string rememberedAnnouncementButton = "//li[@id='rememberMenu']//a[@href='/user/remembered-ads']";
        private static string previousPage = "//*[@id='NotFoundBackLink']/a";
        private static string announcmentList = "//div[@id = 'itemsList']//ul";

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

        public static void EnterTextToSearchField(string text)
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
        public static void ClickToClosePostServices()
        {
            Common.ClickElement(closePostPopUp);
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

        public static void ClickOnApartmentsOption()
        {
            Common.ClickElement(apartments);
        }

        public static void ClickOnPriceFieldFromAndEnterPrice(string priceFrom)
        {
            Common.EnterText(priceFieldFrom, priceFrom);
        }
        //public static void EnterPriceFrom(string priceFrom)
        //{
        //    Common.EnterText(priceFrom);
        //}
        public static void ClickOnPriceFieldToAndEnterPrice(string priceTo)
        {
            Common.EnterText(priceFieldTo, priceTo);
        }

        public static void ClickChooseCityFromFilter()
        {
            Common.ClickElement(CityFilterButton);
        }

        public static void ClickOnCity()
        {
            Common.ClickElement(ChooseCity);
        }

        public static void ClickOnSaveOptionField()
        {
            Common.ClickElement(saveOptionButton);
        }
        //public static void WaitForElementToBeClickableAndClickChooseCituFromFilter()
        //{
        //    Common.ClickEnterButton(minRoomOption);
        //}

        public static void ClickMinRoomOption()
        {
            Common.ClickElement(minRoomOption);
        }

        public static void ClickMinRoomsButton()
        {
            Common.ClickElement(minRooms);
        }

        public static void ClickFiltrateButton()
        {
            Common.ClickElement(filtrateButton); 
        }
        public static void CheckIfAnnouncementListIsVisible()
        {
            Common.WaitForElementToBeVisible(announcmentList);
        }

        public static void ClickOnComputersButton()
        {
            Common.ClickElement(computerButton);
        }

        public static void ClickOnHeartToRememberAnnouncement()
        {
            Common.ClickElement(rememberButton);
        }

        public static void ClickToRememberedAnnouncements()
        {
            Common.ClickElement(rememberedAnnouncementButton);
        }

        public static void ClickReturnToThePreviousPage()
        {
            Common.ClickElement(previousPage);
        }

        public static string LoggedInInfo()
        {
            return Common.GetElement(checkIfLoggedIn).Text;
        }

        public static string SearchSubaruList()
        {
            return Common.GetElement(BRZList).Text;
        }

        public static string ApartmentsSearchResults()
        {
            return Common.GetElement(apartmentsListByFilter).Text;
        }
    }
}
