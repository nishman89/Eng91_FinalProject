using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Eng91FinalProject.lib.driver_config;
using Eng91FinalProject.lib.pages.TraineeTracker;
using Eng91FinalProject.lib.pages.TrainerProfile;
using Eng91FinalProject.lib.pages.TraineeProfile;
using Eng91FinalProject.lib.pages.Navbar;

namespace Eng91FinalProject.lib.pages
{
    public class Website<T> where T : IWebDriver, new()
    {
        public IWebDriver SeleniumDriver { get; set; }
        public SplashPage SplashPage { get; set; }
        public LoginPage LoginPage { get; set; }
        public HomePage HomePage { get; set; }
        public ProfilesPage ProfilesPage { get; set; }
        public TrackerCreatePage TrackerCreatePage { get; set; }
        public TrackerDeletePage TrackerDeletePage { get; set; }
        public TrackerEditPage TrackerEditPage { get; set; }
        public TraineeTrackerPage TraineeTrackerPage { get; set; }
        public TrainerTrackerPage TrainerTrackerPage { get; set; }
        public TrainerProfilePage TrainerProfilePage { get; set; }
        public TrainerProfileEditPage TrainerProfileEditPage { get; set; }
        public TraineeProfilePage TraineeProfilePage { get; set; }
        public TraineeProfileEditPage TraineeProfileEditPage { get; set; }
        public AdminAPICreatePage AdminAPICreatePage { get; set; }
        public AdminAPIPage AdminAPIPage { get; set; }
        public AdminCourseCreatePage AdminCourseCreatePage { get; set; }
        public AdminCourseDeletePage AdminCourseDeletePage { get; set; }
        public AdminCourseEditPage AdminCourseEditPage { get; set; }
        public AdminCoursesPage AdminCoursesPage { get; set; }
        public AdminStreamCreatePage AdminStreamCreatePage { get; set; }
        public AdminStreamDeletePage AdminStreamDeletePage { get; set; }
        public AdminStreamEditPage AdminStreamEditPage { get; set; }
        public AdminStreamPage AdminStreamPage { get; set; }
        public AdminUserCreatePage AdminUserCreatePage { get; set; }
        public AdminUserDeletePage AdminUserDeletePage { get; set; }
        public AdminUsersPage AdminUsersPage { get; set; }
        public BulkImportProfilesPage BulkImportProfilesPage { get; set; }
        public BulkImportUsersPage BulkImportUsersPage { get; set; }
        public SharedNavbar SharedNavbar { get; set; }
        public TrainerNavbar TrainerNavbar { get; set; }
        public TraineeNavbar TraineeNavbar { get;set; }
        public ProgressPage ProgressPage { get; set; }
        public CourseAttendancePage CourseAttendancePage { get; set; }

        public Website(int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            SeleniumDriver = new SeleniumDriverConfig<T>(pageLoadInSecs, implicitWaitInSecs).Driver;

            SplashPage = new SplashPage(SeleniumDriver);
            LoginPage = new LoginPage(SeleniumDriver);
            HomePage = new HomePage(SeleniumDriver);
            ProgressPage = new ProgressPage(SeleniumDriver);
            CourseAttendancePage = new CourseAttendancePage(SeleniumDriver);
            ProfilesPage = new ProfilesPage(SeleniumDriver);
            TraineeTrackerPage = new TraineeTrackerPage(SeleniumDriver);
            TrainerTrackerPage = new TrainerTrackerPage(SeleniumDriver);
            TrainerProfilePage = new TrainerProfilePage(SeleniumDriver);
            TrainerProfileEditPage = new TrainerProfileEditPage(SeleniumDriver);
            TraineeProfilePage = new TraineeProfilePage(SeleniumDriver);
            TraineeProfileEditPage = new TraineeProfileEditPage(SeleniumDriver);
            AdminAPICreatePage = new AdminAPICreatePage(SeleniumDriver);
            AdminAPIPage = new AdminAPIPage(SeleniumDriver);
            AdminCourseCreatePage = new AdminCourseCreatePage(SeleniumDriver);
            AdminCourseDeletePage = new AdminCourseDeletePage(SeleniumDriver);
            AdminCourseEditPage = new AdminCourseEditPage(SeleniumDriver);
            AdminCoursesPage = new AdminCoursesPage(SeleniumDriver);
            AdminStreamCreatePage = new AdminStreamCreatePage(SeleniumDriver);
            AdminStreamDeletePage = new AdminStreamDeletePage(SeleniumDriver);
            AdminStreamEditPage = new AdminStreamEditPage(SeleniumDriver);
            AdminStreamPage = new AdminStreamPage(SeleniumDriver);
            AdminUserCreatePage = new AdminUserCreatePage(SeleniumDriver);
            AdminUserDeletePage = new AdminUserDeletePage(SeleniumDriver);
            AdminStreamEditPage = new AdminStreamEditPage(SeleniumDriver);
            AdminUsersPage = new AdminUsersPage(SeleniumDriver);
            BulkImportProfilesPage = new BulkImportProfilesPage(SeleniumDriver);
            BulkImportUsersPage = new BulkImportUsersPage(SeleniumDriver);
            SharedNavbar = new SharedNavbar(SeleniumDriver);
            TrainerNavbar = new TrainerNavbar(SeleniumDriver);
            TraineeNavbar = new TraineeNavbar(SeleniumDriver);
        }

        public void DeleteCookies() => SeleniumDriver.Manage().Cookies.DeleteAllCookies();
    }
}
