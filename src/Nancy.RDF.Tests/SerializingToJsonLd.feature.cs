﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Nancy.RDF.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Serializing to JSON-LD")]
    public partial class SerializingToJSON_LDFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SerializingToJsonLd.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Serializing to JSON-LD", "\tTest serializing models to JSON-LD", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should pass through serialized model")]
        [NUnit.Framework.CategoryAttribute("Brochure")]
        [NUnit.Framework.CategoryAttribute("JsonLd")]
        public virtual void ShouldPassThroughSerializedModel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should pass through serialized model", new string[] {
                        "Brochure",
                        "JsonLd"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 7
 testRunner.Given("A serialized model:", "{\r\n\t\'@context\': { \r\n\t\t\'title\': \'http://purl.org/dcterms/title\'\r\n\t},\r\n\t\'@id\': \'htt" +
                    "p://wikibus.org/brochure/12345\',\r\n\t\'title\': \'Jelcz M11 - mały, stary autobus\'\r\n}" +
                    "", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("model is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.Then("output stream should equal", "{\r\n\t\'@context\': { \r\n\t\t\'title\': \'http://purl.org/dcterms/title\'\r\n\t},\r\n\t\'@id\': \'htt" +
                    "p://wikibus.org/brochure/12345\',\r\n\t\'title\': \'Jelcz M11 - mały, stary autobus\'\r\n}" +
                    "", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should allow expanded profile")]
        [NUnit.Framework.CategoryAttribute("Brochure")]
        [NUnit.Framework.CategoryAttribute("JsonLd")]
        public virtual void ShouldAllowExpandedProfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should allow expanded profile", new string[] {
                        "Brochure",
                        "JsonLd"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 32
 testRunner.Given("A serialized model:", "{\r\n\t\'@context\': { \r\n\t\t\'title\': \'http://purl.org/dcterms/title\'\r\n\t},\r\n\t\'@id\': \'htt" +
                    "p://wikibus.org/brochure/12345\',\r\n\t\'title\': \'Jelcz M11 - mały, stary autobus\'\r\n}" +
                    "", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.Given("accepted media type \'application/ld+json; profile=http://www.w3.org/ns/json-ld#ex" +
                    "panded\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.When("model is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("output stream should equal", "[{\r\n\t\'@id\': \'http://wikibus.org/brochure/12345\',\r\n\t\'http://purl.org/dcterms/title" +
                    "\': [{\r\n\t\t\'@value\': \'Jelcz M11 - mały, stary autobus\'\r\n\t}]\r\n}]", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
