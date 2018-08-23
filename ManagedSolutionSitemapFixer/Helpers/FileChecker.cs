using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedSolutionSitemapFixer.Helpers
{
    public class FileChecker
    {
        private readonly static string customizationsFileName = "customizations.xml";

        public void CheckFile(string path)
        {            
            if (!File.Exists(path))
            {
                throw new Exception("File not found");
            }

            string fileContent = new ZipHelper().GetFileContent(path, customizationsFileName);

            bool hasSitemap = new FileFixer().ContainsSiteMap(fileContent);
            if(!hasSitemap)
            {
                throw new Exception("No sitemap inside customizations.xml");
            }
        }
    }
}
