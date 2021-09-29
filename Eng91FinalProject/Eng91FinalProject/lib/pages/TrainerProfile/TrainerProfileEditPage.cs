using Eng91FinalProject.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
        private SelectElement _titleDropdown => new SelectElement(_seleniumDriver.FindElement(By.Id("Title")));
        private SelectElement _streamsDropdown => new SelectElement(_seleniumDriver.FindElement(By.Id("StreamIds")));

        

        //Methods
        public void ClickSave() => _save.Click();
        public void SetFirstName(string fName) => _firstName.SendKeys(fName);
        public void SetLastName(string fName) => _lastName.SendKeys(fName);
        public void SetLocation(string fName) => _location.SendKeys(fName);
        public void SetEmail(string fName) => _email.SendKeys(fName);
        
        //Title Dropdown
        
        public void SelectTitleDropdown(string title) => _titleDropdown.SelectByText(title);

        //Steams Dropdown
        public void ClearStreamsDropdown() => _streamsDropdown.DeselectAll();
        public void SelectStream(string course) => _streamsDropdown.SelectByText(course);
        
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
