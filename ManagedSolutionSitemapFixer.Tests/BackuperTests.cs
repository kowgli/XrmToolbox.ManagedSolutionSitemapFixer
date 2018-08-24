using ManagedSolutionSitemapFixer.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace ManagedSolutionSitemapFixer.Tests
{
    [TestClass]
    public class BackuperTests
    {
        [TestMethod]
        public void Can_PerformTheBackup()
        {
            string backupPath = Backuper.Backup(@"TestFiles\text_file.txt");

            string read = File.ReadAllText(backupPath);

            File.Delete(backupPath);

            Assert.AreEqual("hello", read);
        }
    }
}