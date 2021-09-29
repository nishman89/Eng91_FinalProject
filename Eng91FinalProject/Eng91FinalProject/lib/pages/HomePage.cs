using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Eng91FinalProject.lib.pages
{
	public class HomePage
	{
		public HomePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

		#region Properties
		private IWebDriver _seleniumDriver;
		private IWebElement _mainContainer => _seleniumDriver.FindElement(By.ClassName("pb-3"));
		#region Navbar
		private IWebElement _loginButton => _seleniumDriver.FindElement(By.LinkText("Login"));
		private IWebElement _logoutButton => _seleniumDriver.FindElement(By.LinkText("Logout"));
		private IWebElement _homeButton => _seleniumDriver.FindElement(By.LinkText("Home"));
		private IWebElement _profilesButton => _seleniumDriver.FindElement(By.LinkText("Profiles"));
		private IWebElement _traineeTrackerButton => _seleniumDriver.FindElement(By.LinkText("Trainee Tracker"));
		private IWebElement _adminDropdownButton => _seleniumDriver.FindElement(By.Id("adminDropdown"));
		private IWebElement _adminDropdownUsersButton => _seleniumDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[4]/div/a[1]"));
		private IWebElement _adminDropdownStreamsButton => _seleniumDriver.FindElement(By.LinkText("Stream"));
		private IWebElement _adminDropdownCoursesButton => _seleniumDriver.FindElement(By.LinkText("Courses"));
		private IWebElement _adminDropdownAPIButton => _seleniumDriver.FindElement(By.LinkText("API"));

		private IWebElement _bulkImportDropdownButton => _seleniumDriver.FindElement(By.Id(""));
		private IWebElement _bulkImportDropdownUsersButton => _seleniumDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[5]/div/a[2]"));
		private IWebElement _bulkImportDropdownProfilesButton => _seleniumDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[5]/div/a[1]"));

		private IWebElement _trainerProfileButton => _seleniumDriver.FindElement(By.LinkText("jsmith"));
		#endregion
		#region TraineePage - Bhoward
		private IWebElement _traineeProfilePageButton => _seleniumDriver.FindElement(By.LinkText("bhoward"));
		private IWebElement _trackerButton => _seleniumDriver.FindElement(By.LinkText("Tracker"));
		public IReadOnlyCollection<IWebElement> _expandableTestContainers => _seleniumDriver.FindElements(By.ClassName("mb-0"));
		private IWebElement _advancedOOPTestExpandable => _expandableTestContainers.ElementAt(0);
		private IWebElement _OOPTestExpandable => _expandableTestContainers.ElementAt(1);
		private IWebElement _SQLTestExpandable => _expandableTestContainers.ElementAt(2);

		private IReadOnlyCollection<IWebElement> _testListItems => _seleniumDriver.FindElements(By.ClassName("mb-2"));

		#endregion

		#region Stream Student Details
		private IWebElement _trainee1ResultsContainer => _seleniumDriver.FindElement(By.Id("trainee_1_results_container"));
		private IWebElement _progressTrackerButton => _seleniumDriver.FindElement(By.Id("btn-tracker"));
		private IWebElement _expandAndHideAllButton => _seleniumDriver.FindElement(By.Id("btn-course-1-accordion"));
		private IWebElement _courseAttendanceButton => _seleniumDriver.FindElement(By.ClassName("btn btn-primary float-right"));

		private IWebElement _expandedconditionBen => _seleniumDriver.FindElement(By.XPath("/html/body/div/main/div/div/div/div/div/div/div/div[1]/div/div[1]/h4/a"));
		private IWebElement _expandedconditionPhoebe => _seleniumDriver.FindElement(By.XPath("/html/body/div/main/div/div/div/div/div/div/div/div[3]/div/div[1]/h4/a"));

		private IWebElement _expandedconditionStevie => _seleniumDriver.FindElement(By.XPath("/html/body/div/main/div/div/div/div/div/div/div/div[12]/div/div[1]/h4/a"));

		private List<int> expandableContainersNumber = new List<int> { };

		

		#endregion

		#endregion

		#region Methods


		#region Trainee Page Methods
		public void ClicktrackerButton() => _trackerButton.Click();
		public void ClickTraineeProfilePageButton() => _traineeProfilePageButton.Click();
		public void ClickAdvancedOOPTestExpandable() => _advancedOOPTestExpandable.Click();
		public void ClickOOPTestExpandable() => _OOPTestExpandable.Click();
		public void ClickSQLTestExpandable() => _SQLTestExpandable.Click();

		public bool IsExpandedAdvancedOOPTestExpandable() => _advancedOOPTestExpandable.GetAttribute("aria - expanded").Contains("true") ? true : false;
		public bool IsExpandedOOPTestExpandable() => _OOPTestExpandable.GetAttribute("aria - expanded").Contains("true") ? true : false;
		public bool IsExpandedSQLTestExpandable() => _SQLTestExpandable.GetAttribute("aria - expanded").Contains("true") ? true : false;

		public bool TestsAreContained()
		{
			try 
			{
				_testListItems.ElementAt(0).FindElement(By.Id("accordion_Advanced-OOP-and-Unit-Testing"));
				_testListItems.ElementAt(0).FindElement(By.Id("accordion_OOP"));
				_testListItems.ElementAt(0).FindElement(By.Id("accordion_SQL"));
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}
		

		#endregion

		#region Stream Details Methods
		public void ClickTrainee1ResultsContainer() => _trainee1ResultsContainer.Click();
		public void ClickProgressTrackerButton() => _progressTrackerButton.Click();
		public void ClickExpandAndHideAllButton() => _expandAndHideAllButton.Click();
		public void ClickCourseAttendanceButton() => _courseAttendanceButton.Click();
		public bool IsExpandedBen() => _expandedconditionBen.GetAttribute("aria - expanded").Contains("true") ? true : false;
		public bool IsExpandedPhoebe() => _expandedconditionPhoebe.GetAttribute("aria - expanded").Contains("true") ? true : false;

		public bool IsExpandedAll()
		{
			foreach (var container in _expandableTestContainers)
			{

				if (container.GetAttribute("aria - expanded").Contains("true") == false)
				{
					return false;
				}
			}
			return true;
		}

		#endregion
		#region HomePage Check
		public bool IsOnSplashPage()
		{
			try
			{
				_mainContainer.FindElement(By.ClassName("banner hero-video-background"));
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}

		public bool IsOnTrainerHomePage()
		{
			try
			{
				_mainContainer.FindElement(By.ClassName("jumbotron-container"));
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}

		public bool IsOnTraineeHomePage()
		{
			try
			{
				_mainContainer.FindElement(By.ClassName("row justify-content-center align-items-center"));
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}

		public bool IsOnTheLogInPage()
        {
            try
            {
				_mainContainer.FindElement(By.Id("Password"));
				return true;
			}
			catch(NoSuchElementException)
            {
				return false;
            }
        }
		#endregion

		#endregion
	}
}
