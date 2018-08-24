using ManagedSolutionSitemapFixer.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
