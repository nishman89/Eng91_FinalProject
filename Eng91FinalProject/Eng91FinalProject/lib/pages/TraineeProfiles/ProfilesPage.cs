using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages.TraineeProfiles
{
    class ProfilesPage
    {
        //fields
        private IWebDriver _seleniumDriver { get; set; }

        //Methods
        public ProfilesPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
    }
}
