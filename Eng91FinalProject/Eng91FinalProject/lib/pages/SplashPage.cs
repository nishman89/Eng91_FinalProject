using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eng91FinalProject.utils;

namespace Eng91FinalProject.lib.pages
{
    public class SplashPage
    {
        private IWebDriver _seleniumDriver;

        public SplashPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
    }
}
