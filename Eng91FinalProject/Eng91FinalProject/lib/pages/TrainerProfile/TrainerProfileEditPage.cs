using Eng91FinalProject.utils;
using OpenQA.Selenium;


namespace Eng91FinalProject.lib.pages.TrainerProfile
{
    public class TrainerProfileEditPage
    {
        private IWebDriver _seleniumDriver { get; set; }

        
        public TrainerProfileEditPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        private IWebElement _save => _seleniumDriver.FindElement(By.Id("submitChanges"));

        private IWebElement _firstName => _seleniumDriver.FindElement(By.Id("FirstName"));
        private IWebElement _lastName => _seleniumDriver.FindElement(By.Id("LastName"));
        private IWebElement _email => _seleniumDriver.FindElement(By.Id("Email"));
        private IWebElement _location => _seleniumDriver.FindElement(By.Id("Location"));

        // Title Dropdown
        private IWebElement _titleDropdown => _seleniumDriver.FindElement(By.Id("Title"));

        private IWebElement _titleDropdownSelectMr => _seleniumDriver.FindElement(By.Id("bs-select-1-1"));
        private IWebElement _titleDropdownSelectMrs => _seleniumDriver.FindElement(By.Id("bs-select-1-2"));
        private IWebElement _titleDropdownSelectMiss => _seleniumDriver.FindElement(By.Id("bs-select-1-3"));

        private IWebElement _titleDropdownSelectDr => _seleniumDriver.FindElement(By.Id("bs-select-1-4"));

        private IWebElement _titleDropdownSelectMx => _seleniumDriver.FindElement(By.Id("bs-select-1-5"));

        // Stream Dropdown
        private IWebElement _streamsDropdown => _seleniumDriver.FindElement(By.Id("StreamsIds"));
        private IWebElement _streamsDropdownSelectCsharpDev => _seleniumDriver.FindElement(By.Id("bs-select-2-0"));
        private IWebElement _streamsDropdownSelectCsharpSDET => _seleniumDriver.FindElement(By.Id("bs-select-2-1"));
        private IWebElement _streamsDropdownSelectDevOps => _seleniumDriver.FindElement(By.Id("bs-select-2-2"));
        private IWebElement _streamsDropdownSelectBusinessAnalyst => _seleniumDriver.FindElement(By.Id("bs-select-2-3"));
        private IWebElement _streamsDropdownSelectJavaDev => _seleniumDriver.FindElement(By.Id("bs-select-2-4"));


        //Methods
        public void ClickSave() => _save.Click();
        public void SetFirstName(string fName) => _firstName.SendKeys(fName);
        public void SetLastName(string fName) => _lastName.SendKeys(fName);
        public void SetLocation(string fName) => _location.SendKeys(fName);
        public void SetEmail(string fName) => _email.SendKeys(fName);

        //Title Dropdown
        public void SelectTitleDropdown() => _titleDropdown.Click();
        public void SelectTitleDropdownMr() => _titleDropdownSelectMr.Click();
        public void SelectTitleDropdownMrs() => _titleDropdownSelectMrs.Click();
        public void SelectTitleDropdownMiss() => _titleDropdownSelectMiss.Click();
        public void SelectTitleDropdownDr() => _titleDropdownSelectDr.Click();
        public void SelectTitleDropdownMx() => _titleDropdownSelectMx.Click();

        //Steams Dropdown

        public void SelectStreamsDropdown() => _streamsDropdown.Click();
        public void SelectStreamsDropdownSelectCsharpDev() => _streamsDropdownSelectCsharpDev.Click();
        public void SelectStreamsDropdownSelectCsharpSDET() => _streamsDropdownSelectCsharpSDET.Click();
        public void SelectStreamsDropdownSelectDevOps() => _streamsDropdownSelectDevOps.Click();
        public void SelectStreamsDropdownSelectBusinessAnalyst() => _streamsDropdownSelectBusinessAnalyst.Click();
        public void SelectStreamsDropdownSelectJavaDev() => _streamsDropdownSelectJavaDev.Click();

        public void InputFormDetails(TrainerProfileDetails trainerProfileDetails)
        {
            _email.Clear();
            _firstName.Clear();
            _lastName.Clear();
            _location.Clear();
            SetFirstName(trainerProfileDetails.FirstName);
            SetLastName(trainerProfileDetails.LastName);
            SetLocation(trainerProfileDetails.Location);
            SetEmail(trainerProfileDetails.Email);

        }
    }
}
