using ManagedSolutionSitemapFixer.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.Compression;

namespace ManagedSolutionSitemapFixer.Tests
{
    [TestClass]
    public class ZipHelperTests
    {
        [TestMethod]
        public void Can_ReadFileFromZip()
        {
            string expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Types xmlns=\"http://schemas.openxmlformats.org/package/2006/content-types\"><Default Extension=\"xml\" ContentType=\"application/octet-stream\" /></Types>";

            string read = "";

            using (var zipHelper = new ZipHelper())
            {
                read = zipHelper.GetFileContent(@"TestFiles\TestSolution_1_0_0_0_managed.zip", "[Content_Types].xml");
            }

            Assert.AreEqual(expected, read);
        }

        [TestMethod]
        public void Can_PutFileIntoZip()
        {
            // Create temp folder
            string tempFolder = Guid.NewGuid().ToString("N");
            tempFolder = Path.Combine("TestFiles", tempFolder);
            Directory.CreateDirectory(tempFolder);

            // Copy zip to temp folder
            string copiedPath = Path.Combine(tempFolder, "Simple_archive.zip");
            File.Copy(@"TestFiles\Simple_archive.zip", copiedPath);

            // Add file to zip
            using (var zipHelper = new ZipHelper())
            {
                zipHelper.PutFileContent(copiedPath, "test3.txt", "Hello world");
            }

            // Extract using .NET version of zip
            ZipFile.ExtractToDirectory(copiedPath, tempFolder);

            string read = File.ReadAllText(Path.Combine(tempFolder, "test3.txt"));

            // Assert
            Assert.AreEqual("Hello world", read);

            // Cleanup
            Directory.Delete(tempFolder, true);
        }
    }
}