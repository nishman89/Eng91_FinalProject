// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Eng91FinalProject.BDD.TraineeProfile
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TraineeProfileEditPage")]
    public partial class TraineeProfileEditPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TraineeProfileEdit.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BDD/TraineeProfile", "TraineeProfileEditPage", "\tAs a trainee, \r\n\tI want to be able to edit my profile, \r\n\tso that I can update m" +
                    "y details", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit trainee profile")]
        [NUnit.Framework.CategoryAttribute("TraineeProfileEditPage")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        public virtual void EditTraineeProfile()
        {
            string[] tagsOfScenario = new string[] {
                    "TraineeProfileEditPage",
                    "Happy"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit trainee profile", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table77 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table77.AddRow(new string[] {
                            "bhoward@spartaglobal.com",
                            "Password123!"});
#line 8
 testRunner.Given("I am logged in", ((string)(null)), table77, "Given ");
#line hidden
#line 11
 testRunner.When("I click my name to view my Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.And("I click ‘EDIT’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table78 = new TechTalk.SpecFlow.Table(new string[] {
                            "Summary",
                            "LifeStory",
                            "CareerMotivation",
                            "Skills",
                            "Interests",
                            "Education",
                            "Certifications",
                            "AdditionalAchievements",
                            "RecentEmployment",
                            "Volunteering",
                            "LinkedIn",
                            "Github"});
                table78.AddRow(new string[] {
                            "test",
                            "test",
                            "test",
                            "test",
                            "test",
                            "test",
                            "test",
                            "test",
                            "test",
                            "test",
                            "test",
                            "test"});
#line 13
 testRunner.And("I update my details", ((string)(null)), table78, "And ");
#line hidden
#line 16
 testRunner.And("I click ‘SAVE’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Then("my profile is updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to home from trainee profile edit page using image")]
        [NUnit.Framework.CategoryAttribute("TraineeProfileEditPage")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        public virtual void NavigateToHomeFromTraineeProfileEditPageUsingImage()
        {
            string[] tagsOfScenario = new string[] {
                    "TraineeProfileEditPage",
                    "Happy"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to home from trainee profile edit page using image", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table79 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table79.AddRow(new string[] {
                            "bhoward@spartaglobal.com",
                            "Password123!"});
#line 21
 testRunner.Given("I am logged in", ((string)(null)), table79, "Given ");
#line hidden
#line 24
 testRunner.When("I click my name to view my Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.And("I click ‘EDIT’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("I click the Sparta Global image", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.Then("I am taken to the Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to home from trainee profile edit page using home button")]
        [NUnit.Framework.CategoryAttribute("TraineeProfileEditPage")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        public virtual void NavigateToHomeFromTraineeProfileEditPageUsingHomeButton()
        {
            string[] tagsOfScenario = new string[] {
                    "TraineeProfileEditPage",
                    "Happy"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to home from trainee profile edit page using home button", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table80 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table80.AddRow(new string[] {
                            "bhoward@spartaglobal.com",
                            "Password123!"});
#line 31
 testRunner.Given("I am logged in", ((string)(null)), table80, "Given ");
#line hidden
#line 34
 testRunner.When("I click my name to view my Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And("I click ‘EDIT’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("I click ‘Home’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.Then("I am taken to the Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to profiles from trainee profile edit page")]
        [NUnit.Framework.CategoryAttribute("TraineeProfileEditPage")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        public virtual void NavigateToProfilesFromTraineeProfileEditPage()
        {
            string[] tagsOfScenario = new string[] {
                    "TraineeProfileEditPage",
                    "Happy"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to profiles from trainee profile edit page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table81 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table81.AddRow(new string[] {
                            "bhoward@spartaglobal.com",
                            "Password123!"});
#line 41
 testRunner.Given("I am logged in", ((string)(null)), table81, "Given ");
#line hidden
#line 44
 testRunner.When("I click my name to view my Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.And("I click ‘EDIT’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("I click ‘Profiles’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.Then("I am taken to the Profiles Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Log out when on trainee profile edit page")]
        [NUnit.Framework.CategoryAttribute("TraineeProfileEditPage")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        public virtual void LogOutWhenOnTraineeProfileEditPage()
        {
            string[] tagsOfScenario = new string[] {
                    "TraineeProfileEditPage",
                    "Happy"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Log out when on trainee profile edit page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 50
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table82 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table82.AddRow(new string[] {
                            "bhoward@spartaglobal.com",
                            "Password123!"});
#line 51
 testRunner.Given("I am logged in", ((string)(null)), table82, "Given ");
#line hidden
#line 54
 testRunner.When("I click my name to view my Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.And("I click ‘EDIT’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("I click ‘Logout’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("I am logged out and sent to the Splash Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to trainee profile page when on trainee profile edit page")]
        [NUnit.Framework.CategoryAttribute("TraineeProfileEditPage")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        public virtual void NavigateToTraineeProfilePageWhenOnTraineeProfileEditPage()
        {
            string[] tagsOfScenario = new string[] {
                    "TraineeProfileEditPage",
                    "Happy"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to trainee profile page when on trainee profile edit page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 60
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table83 = new TechTalk.SpecFlow.Table(new string[] {
                            "Email",
                            "Password"});
                table83.AddRow(new string[] {
                            "bhoward@spartaglobal.com",
                            "Password123!"});
#line 61
 testRunner.Given("I am logged in", ((string)(null)), table83, "Given ");
#line hidden
#line 64
 testRunner.When("I click my name to view my Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
 testRunner.And("I click ‘EDIT’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("I click my name to view my Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.Then("I am taken to my Profile Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
