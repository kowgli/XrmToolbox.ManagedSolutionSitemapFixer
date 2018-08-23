using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagedSolutionSitemapFixer.Helpers
{
    public class FileFixer
    {
        private readonly static string sitemapRegex = @"<SiteMap>(.|\n)*?<SiteMap>(.|\n)*?<\/SiteMap>(.|\n)*?<\/SiteMap>";

        public bool ContainsSiteMap(string fileContent)
        {
            Match match = Regex.Match(fileContent, sitemapRegex);

            return match.Success;
        }

        public string GetSiteMap(string fileContent)
        {
            Match match = Regex.Match(fileContent, sitemapRegex);

            return match.Value;
        }
    }
}
