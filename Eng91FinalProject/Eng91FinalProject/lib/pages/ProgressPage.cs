using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Eng91FinalProject.lib.pages
{
	public class ProgressPage
	{
		private IWebDriver _seleniumDriver;
		public ProgressPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
		private IWebElement _progressChart => _seleniumDriver.FindElement(By.Id("highcharts-tdcn5wb-0"));

	}
}
