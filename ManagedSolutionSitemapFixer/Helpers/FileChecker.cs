using System;
using System.IO;

namespace ManagedSolutionSitemapFixer.Helpers
{
    public static class FileChecker
    {
        public static void CheckFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("File not found");
            }

            using (var zipHelper = new ZipHelper())
            {
                string fileContent = zipHelper.GetFileContent(path, Statics.CustomizationsFileName);

                bool hasSitemap = CustomizationsFileProcessor.ContainsSiteMap(fileContent);
                if (!hasSitemap)
                {
                    throw new Exception("No sitemap inside customizations.xml");
                }
            }
        }
    }
}