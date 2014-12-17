﻿using FeatherWidgets.TestUtilities.CommonOperations;
using MbUnit.Framework;
using Telerik.Sitefinity.TestUI.Arrangements.Framework;
using Telerik.Sitefinity.TestUI.Arrangements.Framework.Attributes;
using Telerik.Sitefinity.TestUtilities.CommonOperations;

namespace FeatherWidgets.TestUI.Arrangements
{
    /// <summary>
    /// Test arrangements for DynamicModuleRemoveContentTypeVerifyPageToolbox
    /// </summary>
    public class DynamicModuleRemoveContentTypeVerifyPageToolbox : ITestArrangement
    {
        /// <summary>
        /// Server side set up.
        /// </summary>
        [ServerSetUp]
        public void SetUp()
        {
            ServerOperationsFeather.DynamicModules().ImportModule(ModuleResource);
            ServerOperations.ModuleBuilder().ActivateModule(ModuleName, string.Empty, TransactionName);
        }

        /// <summary>
        /// Server arrangement.
        /// </summary>
        [ServerArrangement]
        public void VerifyToolboxConfigBeforeDeleteContentType()
        {
            string dynamicWidgetSection = ModuleName;
            var section = ServerOperationsFeather.Pages().GetDynamicWidgetToolboxSection(dynamicWidgetSection);
            int expectedCount = 6;

            Assert.IsTrue(section.Tools.Count.Equals(expectedCount), "Widgets count is unexpected.");
            Assert.IsTrue(ServerOperationsFeather.Pages().IsWidgetPresentInToolbox(section, DynamicWidgetMVCTitle), "Widget not found: " + DynamicWidgetMVCTitle);
        }

        /// <summary>
        /// Server arrangement.
        /// </summary>
        [ServerArrangement]
        public void VerifyToolboxConfig()
        {
            string dynamicWidgetSection = ModuleName;
            var section = ServerOperationsFeather.Pages().GetDynamicWidgetToolboxSection(dynamicWidgetSection);
            int expectedCount = 4;

            Assert.IsTrue(section.Tools.Count.Equals(expectedCount), "Widgets count is unexpected.");
            Assert.IsFalse(ServerOperationsFeather.Pages().IsWidgetPresentInToolbox(section, DynamicWidgetMVCTitle), "Widget was found: " + DynamicWidgetMVCTitle);
        }

        /// <summary>
        /// Tears down.
        /// </summary>
        [ServerTearDown]
        public void TearDown()
        {
            ServerOperations.ModuleBuilder().DeleteAllModules(string.Empty, TransactionName);
        }

        private const string ModuleName = "Music Collection";
        private const string ModuleResource = "FeatherWidgets.TestUtilities.Data.DynamicModules.MusicCollectionAdvanced.zip";
        private const string TransactionName = "Module Installations";
        private const string DynamicWidgetMVCTitle = "Songs MVC";
    }
}