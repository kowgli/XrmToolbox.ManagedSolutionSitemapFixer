using ManagedSolutionSitemapFixer.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedSolutionSitemapFixer.Tests
{
    [TestClass]
    public class CustomizationsFileProcessorTests
    {
        string xmlWithSitemap = @"<root><node><SiteMap><SiteMap><something></something></SiteMap></SiteMap></node></node>";
        string xmlWithNoSitemap = @"<root><node></node></node>";

        [TestMethod]
        public void When_HasSitemap_SaysSo()
        {
            bool contains = CustomizationsFileProcessor.ContainsSiteMap(xmlWithSitemap);

            Assert.IsTrue(contains);
        }

        [TestMethod]
        public void When_DoesntHaveSitemap_SaysSo()
        {
            bool contains = CustomizationsFileProcessor.ContainsSiteMap(xmlWithNoSitemap);

            Assert.IsFalse(contains);
        }

        [TestMethod]
        public void Can_GetSitemap_OutOfXml()
        {
            string sitemap = CustomizationsFileProcessor.GetSiteMap(xmlWithSitemap);

            Assert.AreEqual("<SiteMap><SiteMap><something></something></SiteMap></SiteMap>", sitemap);
        }

        [TestMethod]
        public void Can_ReplaceSitemap_InXml()
        {
            string replaced = CustomizationsFileProcessor.ReplaceSitemap(xmlWithSitemap, "<replaced></replaced>");

            Assert.AreEqual("<root><node><replaced></replaced></node></node>", replaced);
        }
    }
}
