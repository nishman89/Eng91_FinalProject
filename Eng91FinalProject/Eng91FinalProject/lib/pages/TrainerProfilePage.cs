using OpenQA.Selenium;


namespace Eng91FinalProject.lib.pages
{
    public class TrainerProfilePage
    {
        private IWebDriver _seleniumDriver { get; set; }

        //Methods
        public TrainerProfilePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        private IWebElement _editButton => _seleniumDriver.FindElement(By.Id("EditButton"));
        private IWebElement _email => _seleniumDriver.FindElement(By.Id("EditButton"));
        private IWebElement _location => _seleniumDriver.FindElement(By.Id("EditButton"));
        private IWebElement _streams => _seleniumDriver.FindElement(By.Id("TrainerStreams"));
        private IWebElement _profileName => _seleniumDriver.FindElement(By.ClassName("mt-3"));

    }
}
