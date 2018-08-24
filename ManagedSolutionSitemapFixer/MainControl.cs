using ICSharpCode.TextEditor.Document;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace ManagedSolutionSitemapFixer
{
    public partial class MainControl : PluginControlBase
    {      
        private static readonly Color badColor = Color.FromArgb(250, 76, 76);
        private static readonly Color goodColor = Color.FromArgb(108, 234, 92);

        public MainControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            teReplacementSitemap.Document.HighlightingStrategy = HighlightingManager.Manager.FindHighlighter("XML");
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
        }

        private void tbSolutionFile_TextChanged(object sender, EventArgs e)
        {
            SolutionFileChanged();
        }

        private void SolutionFileChanged()
        {
            HideNotification();

            try
            {
                Helpers.FileChecker.CheckFile(tbSolutionFile.Text);
                tbSolutionFile.BackColor = goodColor;
                bFix.Enabled = true;
            }
            catch (Exception ex)
            {
                ShowErrorNotification(ex.Message, null);
                tbSolutionFile.BackColor = badColor;
                bFix.Enabled = false;
            }
        }

        private void bPickSolutionFile_Click(object sender, EventArgs e)
        {
            if (ofdZip.ShowDialog() == DialogResult.OK)
            {
                tbSolutionFile.Text = ofdZip.FileName;
            }
        }

        private void bLoadFromFile_Click(object sender, EventArgs e)
        {
            HideNotification();

            if (ofdXml.ShowDialog() == DialogResult.OK && File.Exists(ofdXml.FileName))
            {
                teReplacementSitemap.Text = File.ReadAllText(ofdXml.FileName);
            }
        }

        private void bLoadFromSolution_Click(object sender, EventArgs e)
        {
            HideNotification();

            try
            {
                using (var zipHelper = new Helpers.ZipHelper())
                {
                    string fileContent = zipHelper.GetFileContent(tbSolutionFile.Text, Helpers.Statics.CustomizationsFileName);
                    string xml = Helpers.CustomizationsFileProcessor.GetSiteMap(fileContent);

                    teReplacementSitemap.Text = xml;
                }
            }
            catch (Exception ex)
            {
                ShowErrorNotification(ex.Message, null);
                tbSolutionFile.BackColor = badColor;
            }
        }

        private void bFix_Click(object sender, EventArgs e)
        {
            HideNotification();

            try
            {
                if (cbCreateBackup.Checked)
                {
                    string backupFileName = Helpers.Backuper.Backup(tbSolutionFile.Text);
                    ShowInfoNotification($"Backed up to {backupFileName}", null);
                }

                Helpers.FileFixer.Fix(tbSolutionFile.Text, teReplacementSitemap.Text);
                ShowInfoNotification($"Sitemap replaced in {tbSolutionFile.Text}", null);
            }
            catch (Exception ex)
            {
                ShowErrorNotification(ex.Message, null);
            }
        }

        private void bSaveToFile_Click(object sender, EventArgs e)
        {
            if (sfdXml.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfdXml.FileName, teReplacementSitemap.Text);
            }
        }
    }
}