using OpenQA.Selenium;

namespace Eng91FinalProject.lib.pages.TraineeProfile
{
    public class TraineeProfileEditPage
    {
        private IWebDriver _seleniumDriver { get; set; }
        public TraineeProfileEditPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        private IWebElement _saveButton => _seleniumDriver.FindElement(By.Id("submitChanges"));
        private IWebElement _summaryBox => _seleniumDriver.FindElement(By.Id("Summary"));
        private IWebElement _lifeStoryBox => _seleniumDriver.FindElement(By.Id("LifeStory"));
        private IWebElement _careerMotivationBox => _seleniumDriver.FindElement(By.Id("WorkMotivation"));
        private IWebElement _skillsBox => _seleniumDriver.FindElement(By.Id("Skills"));
        private IWebElement _interestsBox => _seleniumDriver.FindElement(By.Id("Interests"));
        private IWebElement _educationBox => _seleniumDriver.FindElement(By.Id("Education"));
        private IWebElement _certificationsBox => _seleniumDriver.FindElement(By.Id("Certifications"));
        private IWebElement _additionalAchievementsBox => _seleniumDriver.FindElement(By.Id("AdditionalAchievements"));
        private IWebElement _recentEmploymentBox => _seleniumDriver.FindElement(By.Id("RecentEmployment"));
        private IWebElement _volunteeringBox => _seleniumDriver.FindElement(By.Id("Volunteering"));
        private IWebElement _linkedinBox => _seleniumDriver.FindElement(By.Id("LinkedIn"));
        private IWebElement _githubBox => _seleniumDriver.FindElement(By.Id("GitHub"));
        private IWebElement _chooseFileButton => _seleniumDriver.FindElement(By.Id("NewPhotoUpload"));

        public void ClickSaveButton() => _saveButton.Click();
        public void InputSummary(string summary) => _summaryBox.SendKeys(summary);
        public void InputLifeStory(string lifeStory) => _lifeStoryBox.SendKeys(lifeStory);
        public void InputCareerMotivation(string careerMotivation) => _careerMotivationBox.SendKeys(careerMotivation);
        public void InputSkills(string skills) => _skillsBox.SendKeys(skills);
        public void InputInterests(string interests) => _interestsBox.SendKeys(interests);
        public void InputEducation(string education) => _educationBox.SendKeys(education);
        public void InputCertifications(string certifications) => _certificationsBox.SendKeys(certifications);
        public void InputAdditionalAchievements(string additionalAchievements) => _additionalAchievementsBox.SendKeys(additionalAchievements);
        public void InputRecentEmployment(string recentEmployment) => _recentEmploymentBox.SendKeys(recentEmployment);
        public void InputVolunteering(string volunteering) => _volunteeringBox.SendKeys(volunteering);
        public void InputLinkedIn(string linkedIn) => _linkedinBox.SendKeys(linkedIn);
        public void InputGithub(string github) => _githubBox.SendKeys(github);
        public void ChooseFile() => _chooseFileButton.Click();
    }
}
