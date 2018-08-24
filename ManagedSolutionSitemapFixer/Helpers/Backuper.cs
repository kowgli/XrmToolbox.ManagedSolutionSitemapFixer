using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedSolutionSitemapFixer.Helpers
{
    public static class Backuper
    {
        public static string Backup(string file)
        {
            FileInfo fileInfo = new FileInfo(file);

            string nowString = DateTime.Now.ToString("yyyyMMddHHmmss");
            string backupFileName = $@"{fileInfo.DirectoryName}\{Path.GetFileNameWithoutExtension(fileInfo.Name)}_backup_{nowString}{fileInfo.Extension}";

            File.Copy(fileInfo.FullName, backupFileName);

            return backupFileName;
        }
    }
}
