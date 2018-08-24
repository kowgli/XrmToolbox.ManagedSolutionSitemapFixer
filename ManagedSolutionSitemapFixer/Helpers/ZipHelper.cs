using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedSolutionSitemapFixer.Helpers
{
    public class ZipHelper : IDisposable
    {
        private string tempFolder;

        public ZipHelper()
        {
            string tempRoot = Path.GetTempPath();
            tempFolder = Path.Combine(tempRoot, $"ManagedSolutionSitemapFixer_{Guid.NewGuid().ToString("N")}");
        }

        public void Dispose()
        {
            try
            {
                Directory.Delete(tempFolder, true);
            }
            catch
            {
            }
        }

        public string GetFileContent(string zipFilePath, string fileName)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(zipFilePath))
                {
                    zip[fileName].Extract(tempFolder);
                }
            }
            catch(ZipException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (NullReferenceException)
            {
                throw new Exception($"File {fileName} not found in zip");
            }

            string extractedFilePath = Path.Combine(tempFolder, fileName);

            string content = File.ReadAllText(extractedFilePath);

            File.Delete(extractedFilePath);

            return content;
        }

        public void PutFileContent(string zipFilePath, string fileName, string content)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(zipFilePath))
                {
                    string replacementFileName = Path.Combine(tempFolder, fileName);
                    File.WriteAllText(replacementFileName, content);

                    zip.UpdateFile(replacementFileName, "");
                    zip.Save();
                }
            }
            catch (ZipException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
