using OpenQA.Selenium;
using System.Collections.Generic;

namespace Eng91FinalProject.lib.pages.Profiles
{
    public class ProfilesPage
    {
        private IWebDriver _seleniumDriver { get; set; }

        private int _numProfiles => _seleniumDriver.FindElements(By.ClassName("card")) == null ? 0 : _seleniumDriver.FindElements(By.ClassName("card")).Count;
        private IWebElement _selectedProfile;
        private string _selectedProfileName = "";

        //Methods
        public ProfilesPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void SelectProfile(int profileNum)
        {
            _selectedProfile = _seleniumDriver.FindElement(By.CssSelector($"[href*='/Profile/View/{profileNum}']"));

            //assign selected profile name for current profile
            _selectedProfileName = _seleniumDriver.FindElement(By.XPath($"/html/body/div/main/div[2]/div/div/div[{profileNum}]" +
                $"/div/div/div/div/div/div/div/div/div/div/h4[1]")).Text;
        }
        public void ClickSelectedProfile() => _selectedProfile.Click();
        public string GetSelectedProfileName() => _selectedProfileName;
        public int GetNumProfiles() => _numProfiles;
        public string GetViewedProfileName() => _seleniumDriver.FindElement(By.XPath("/html/body/div/main/div/div/div/div[2]/div[1]/div/div[1]/div[2]")).Text;

        public List<string> GetAllViewedProfileNames()
        {
            var viewedProfileNames = new List<string>();
            if (_numProfiles > 0)
            {
                for (int i = 1; i <= _numProfiles; i++)
                {
                    SelectProfile(i);
                    ClickSelectedProfile();
                    viewedProfileNames.Add(GetViewedProfileName());
                    _seleniumDriver.Navigate().Back();
                }
            }
            return viewedProfileNames;
        }

        public List<string> GetAllProfileNames()
        {
            var profileNames = new List<string>();
            if (_numProfiles > 0)
            {
                for (int i = 1; i <= _numProfiles; i++)
                {
                    SelectProfile(i);
                    profileNames.Add(_selectedProfileName);
                }
            }
            return profileNames;
            
        }
        
    }
}
