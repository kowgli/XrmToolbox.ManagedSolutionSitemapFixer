﻿using System.Text.RegularExpressions;

namespace ManagedSolutionSitemapFixer.Helpers
{
    public static class CustomizationsFileProcessor
    {
        private readonly static string sitemapRegex = @"<SiteMap>(.|\n)*?<SiteMap>(.|\n)*?<\/SiteMap>(.|\n)*?<\/SiteMap>";

        public static bool ContainsSiteMap(string fileContent)
        {
            Match match = Regex.Match(fileContent, sitemapRegex);

            return match.Success;
        }

        public static string GetSiteMap(string fileContent)
        {
            Match match = Regex.Match(fileContent, sitemapRegex);

            return match.Value;
        }

        public static string ReplaceSitemap(string fileContent, string replacement)
        {
            return Regex.Replace(fileContent, sitemapRegex, replacement);
        }
    }
}