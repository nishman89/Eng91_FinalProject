using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminCourse
{
    public class AdminCourseSharedSteps : SharedNavbarSteps
    {
        [Then(@"the result should show '(.*)'")]
        public void ThenTheResultShouldShow(string course)
        {
            string formatCourse = Website.AdminCoursesPage.FormatSearch(course);
            Assert.That(Website.AdminCoursesPage.SearchResult(formatCourse), Is.EqualTo(course));
        }
    }
}
