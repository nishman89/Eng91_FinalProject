using OpenQA.Selenium;


namespace Eng91FinalProject.lib.pages.Navbar
{
    public class TrainerNavbar
    {
        private IWebDriver _seleniumDriver { get; set; }
        
        private IWebElement _profilesButton => _seleniumDriver.FindElement(By.LinkText("Profiles"));
        private IWebElement _trackerButton => _seleniumDriver.FindElement(By.LinkText("Tracker"));

        //Admin Dropdown
        private IWebElement _adminDropdownButton => _seleniumDriver.FindElement(By.Id("adminDropdown"));
        private IWebElement _adminDropdownUsersButton => _seleniumDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[4]/div/a[1]"));
        private IWebElement _adminDropdownStreamsButton => _seleniumDriver.FindElement(By.LinkText("Stream"));
        private IWebElement _adminDropdownCoursesButton => _seleniumDriver.FindElement(By.LinkText("Courses"));
        private IWebElement _adminDropdownAPIButton => _seleniumDriver.FindElement(By.LinkText("API"));


        //BulkImport
        private IWebElement _bulkImportDropdownButton => _seleniumDriver.FindElement(By.Id(""));
        private IWebElement _bulkImportDropdownUsersButton => _seleniumDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[5]/div/a[2]"));
        private IWebElement _bulkImportDropdownProfilesButton => _seleniumDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[5]/div/a[1]"));
        private IWebElement _trainerProfileButton => _seleniumDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[1]/li[1]/a"));
        public TrainerNavbar(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        //Methods
        public void ClickProfilesButton() => _profilesButton.Click();
        public void ClickTraineeTrackerButton() => _trackerButton.Click();
        public void ClickTrainerProfileButton() => _trainerProfileButton.Click();
        //Admin dropdown
        public void ClickAdminDropdownButton() => _adminDropdownButton.Click();
        public void ClickAdminDropdownUsersButton() => _adminDropdownUsersButton.Click();
        public void ClickAdminDropdownStreamsButton() => _adminDropdownStreamsButton.Click();
        public void ClickAdminDropdownCoursesButton() => _adminDropdownCoursesButton.Click();
        public void ClickAdminDropdownAPIButton() => _adminDropdownAPIButton.Click();

        //Bulk Import dropdown
        public void ClickBulkImportDropdownButton() => _bulkImportDropdownButton.Click();
        public void ClickBulkImportDropdownUsersButton() => _bulkImportDropdownUsersButton.Click();
        public void ClickBulkImportDropdownProfilesButton() => _bulkImportDropdownProfilesButton.Click();


    }
}
