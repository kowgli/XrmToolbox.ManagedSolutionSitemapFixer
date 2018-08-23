﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.IO;
using ICSharpCode.TextEditor.Document;

namespace ManagedSolutionSitemapFixer
{
    public partial class MainControl : PluginControlBase
    {
        private Settings mySettings;
        private static readonly Color badColor = Color.FromArgb(250, 76, 76);
        private static readonly Color goodColor = Color.FromArgb(108, 234, 92);

        public MainControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            textEditorControl1.Document.HighlightingStrategy = HighlightingManager.Manager.FindHighlighter("XML");
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
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
                new Helpers.FileChecker().CheckFile(tbSolutionFile.Text);
                tbSolutionFile.BackColor = goodColor;                
            }
            catch(Exception ex)
            {
                ShowErrorNotification(ex.Message, null);
                tbSolutionFile.BackColor = badColor;
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
            if (ofdXml.ShowDialog() == DialogResult.OK && File.Exists(ofdXml.FileName))
            {
                textEditorControl1.Text = File.ReadAllText(ofdXml.FileName);
            }
        }

        private void bLoadFromSolution_Click(object sender, EventArgs e)
        {
            string fileContent = new Helpers.ZipHelper().GetFileContent(tbSolutionFile.Text, "customizations.xml");
            string xml = new Helpers.FileFixer().GetSiteMap(fileContent);

            textEditorControl1.Text = xml;
        }
    }
}