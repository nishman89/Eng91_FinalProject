using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Eng91FinalProject.lib.pages
{
	public class CourseAttendancePage
	{
		private IWebDriver _seleniumDriver;
		public CourseAttendancePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

		private IWebElement _streamTitleHeader => _seleniumDriver.FindElement(By.TagName("h1"));

		private IWebElement _attendanceTable => _seleniumDriver.FindElement(By.Id("attendanceTable"));
		private IReadOnlyCollection<IWebElement> _tableRows => _attendanceTable.FindElements(By.ClassName("AttendanceRow"));

		public int StudentCount()
		{
			return _tableRows.Count();
		}
		public string GetStreamTitle()
		{
			return _streamTitleHeader.Text;
		}
	}
}
