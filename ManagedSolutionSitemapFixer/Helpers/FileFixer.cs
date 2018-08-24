namespace ManagedSolutionSitemapFixer.Helpers
{
    public static class FileFixer
    {
        public static void Fix(string sourceFilePath, string replacementSiteMap)
        {
            using (var zipHelper = new ZipHelper())
            {
                string fileContent = zipHelper.GetFileContent(sourceFilePath, Helpers.Statics.CustomizationsFileName);
                string replacement = replacementSiteMap;
                string fixedXml = Helpers.CustomizationsFileProcessor.ReplaceSitemap(fileContent, replacement);
                zipHelper.PutFileContent(sourceFilePath, Helpers.Statics.CustomizationsFileName, fixedXml);
            }
        }
    }
}