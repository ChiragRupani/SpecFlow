﻿using System.Reflection;
using NUnit.Framework;
using TechTalk.SpecFlow.MsBuildNetSdk.IntegrationTests.Features;

namespace TechTalk.SpecFlow.MsBuildNetSdk.IntegrationTests
{
    [TestFixture]
    public class CodeBehindFileGenerationTests
    {
        [Test]
        public void TestIfCodeBehindFilesWasGeneratedAndCompiled()
        {
            var assemblyHoldingThisClass = Assembly.GetExecutingAssembly();
            var typeOfGeneratedFeatureFile = assemblyHoldingThisClass.GetType(
                "TechTalk.SpecFlow.MsBuildNetSdk.IntegrationTests.Features.DummyFeatureFileToTestMSBuildNetsdkCodebehindFileGenerationFeature");                
            Assert.IsNotNull(typeOfGeneratedFeatureFile);
        }
    }
}
