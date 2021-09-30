﻿// ------------------------------------------------------------------------------
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
namespace Eng91FinalProject.BDD.AdminStream
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AdminStreamEdit")]
    public partial class AdminStreamEditFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AdminStreamEdit.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BDD/AdminStream", "AdminStreamEdit", "\tAs an admin\r\n\tI want to edit a stream\r\n\tSo that I can edit the details of a stre" +
                    "am", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Admin wants to edit a C# Developer stream")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        [NUnit.Framework.CategoryAttribute("AdminStreamEdit")]
        public virtual void AdminWantsToEditACDeveloperStream()
        {
            string[] tagsOfScenario = new string[] {
                    "Happy",
                    "AdminStreamEdit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Admin wants to edit a C# Developer stream", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "email",
                            "password"});
                table16.AddRow(new string[] {
                            "jsmith@spartaglobal.com",
                            "Password123!"});
#line 8
 testRunner.Given("I am logged in", ((string)(null)), table16, "Given ");
#line hidden
#line 11
 testRunner.And("I click Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("I click Streams", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.When("I click Edit on \'C# Developer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("I should be taken to the Edit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Admin wants to edit a C# SDET stream")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        [NUnit.Framework.CategoryAttribute("AdminStreamEdit")]
        public virtual void AdminWantsToEditACSDETStream()
        {
            string[] tagsOfScenario = new string[] {
                    "Happy",
                    "AdminStreamEdit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Admin wants to edit a C# SDET stream", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
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
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "email",
                            "password"});
                table17.AddRow(new string[] {
                            "jsmith@spartaglobal.com",
                            "Password123!"});
#line 18
 testRunner.Given("I am logged in", ((string)(null)), table17, "Given ");
#line hidden
#line 21
 testRunner.And("I click Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("I click Streams", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.When("I click Edit on \'C# SDET\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("I should be taken to the Edit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Admin wants to edit a Business Analyst stream")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        [NUnit.Framework.CategoryAttribute("AdminStreamEdit")]
        public virtual void AdminWantsToEditABusinessAnalystStream()
        {
            string[] tagsOfScenario = new string[] {
                    "Happy",
                    "AdminStreamEdit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Admin wants to edit a Business Analyst stream", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 27
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
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "email",
                            "password"});
                table18.AddRow(new string[] {
                            "jsmith@spartaglobal.com",
                            "Password123!"});
#line 28
 testRunner.Given("I am logged in", ((string)(null)), table18, "Given ");
#line hidden
#line 31
 testRunner.And("I click Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("I click Streams", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.When("I click Edit on \'Business Analyst\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("I should be taken to the Edit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Admin wants to edit a Java Developer stream")]
        [NUnit.Framework.CategoryAttribute("Happy")]
        [NUnit.Framework.CategoryAttribute("AdminStreamEdit")]
        public virtual void AdminWantsToEditAJavaDeveloperStream()
        {
            string[] tagsOfScenario = new string[] {
                    "Happy",
                    "AdminStreamEdit"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Admin wants to edit a Java Developer stream", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 37
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
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "email",
                            "password"});
                table19.AddRow(new string[] {
                            "jsmith@spartaglobal.com",
                            "Password123!"});
#line 38
 testRunner.Given("I am logged in", ((string)(null)), table19, "Given ");
#line hidden
#line 41
 testRunner.And("I click Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("I click Streams", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.When("I click Edit on \'Java Developer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("I should be taken to the Edit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
