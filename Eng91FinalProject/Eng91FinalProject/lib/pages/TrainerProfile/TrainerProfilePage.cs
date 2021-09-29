using OpenQA.Selenium;


namespace Eng91FinalProject.lib.pages.TrainerProfile
{
    public class TrainerProfilePage
    {
        private IWebDriver _seleniumDriver { get; set; }

        //Methods
        public TrainerProfilePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        private IWebElement _editButton => _seleniumDriver.FindElement(By.Id("EditButton"));
        private IWebElement _email => _seleniumDriver.FindElement(By.Id("EmailLabel"));
        private IWebElement _location => _seleniumDriver.FindElement(By.Id("LocationLabel"));
        private IWebElement _streams => _seleniumDriver.FindElement(By.XPath("/html/body/div/main/div/form/div/div[2]/div/div/div[5]/div/ul/li"));
        private IWebElement _profileName => _seleniumDriver.FindElement(By.ClassName("card"));
        
        

        //Methods
        public void ClickEditButton() => _editButton.Click();
        public string GetEmail() => _email.Text;
        public string GetLocation() => _location.Text;
        public string GetStreams() => _streams.Text;
        public string GetProfileName() => _profileName.Text;
        public string GetPageTitle() => _seleniumDriver.Title;

        

    }
}
