using ManagedSolutionSitemapFixer.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ManagedSolutionSitemapFixer.Tests
{
    [TestClass]
    public class FileCheckerTests
    {
        [TestMethod]
        public void When_FileOK_DoesntThrowException()
        {
            FileChecker.CheckFile(@"TestFiles\TestSolution_1_0_0_0_managed.zip");
        }

        [TestMethod]
        public void When_FileDoesntExists_Throws_SaysFileNotFound()
        {
            Exception ex = Assert.ThrowsException<Exception>(() => FileChecker.CheckFile(@"TestFiles\does_not_exists.zip"));
            Assert.AreEqual("File not found", ex.Message);
        }

        [TestMethod]
        public void When_NotAValidZip_Throws_SaysNotValidZip()
        {
            Exception ex = Assert.ThrowsException<Exception>(() => FileChecker.CheckFile(@"TestFiles\this_is_not_a_zip.zip"));
            Assert.AreEqual("Cannot read that as a ZipFile", ex.Message);
        }

        [TestMethod]
        public void When_ValidZipButNoCustomizations_Throws_SaysFileNotFound()
        {
            Exception ex = Assert.ThrowsException<Exception>(() => FileChecker.CheckFile(@"TestFiles\TestSolution_1_0_0_0_with_no_customizations.zip"));
            Assert.AreEqual("File customizations.xml not found in zip", ex.Message);
        }

        [TestMethod]
        public void When_CustomizationsDoNotHaveSitemap_Throws_SaysNoSiteMapFound()
        {
            Exception ex = Assert.ThrowsException<Exception>(() => FileChecker.CheckFile(@"TestFiles\TestSolution_1_0_0_0_managed_no_sitemap.zip"));
            Assert.AreEqual("No sitemap inside customizations.xml", ex.Message);
        }
    }
}