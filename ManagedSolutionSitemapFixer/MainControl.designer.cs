namespace ManagedSolutionSitemapFixer
{
    partial class MainControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSolutionFile = new System.Windows.Forms.Label();
            this.tbSolutionFile = new System.Windows.Forms.TextBox();
            this.bPickSolutionFile = new System.Windows.Forms.Button();
            this.ofdZip = new System.Windows.Forms.OpenFileDialog();
            this.lbReplacementSitemap = new System.Windows.Forms.Label();
            this.bLoadFromSolution = new System.Windows.Forms.Button();
            this.bLoadFromFile = new System.Windows.Forms.Button();
            this.ofdXml = new System.Windows.Forms.OpenFileDialog();
            this.teReplacementSitemap = new ICSharpCode.TextEditor.TextEditorControl();
            this.bFix = new System.Windows.Forms.Button();
            this.cbCreateBackup = new System.Windows.Forms.CheckBox();
            this.bSaveToFile = new System.Windows.Forms.Button();
            this.sfdXml = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbSolutionFile
            // 
            this.lbSolutionFile.AutoSize = true;
            this.lbSolutionFile.Location = new System.Drawing.Point(3, 7);
            this.lbSolutionFile.Name = "lbSolutionFile";
            this.lbSolutionFile.Size = new System.Drawing.Size(64, 13);
            this.lbSolutionFile.TabIndex = 0;
            this.lbSolutionFile.Text = "Solution file:";
            // 
            // tbSolutionFile
            // 
            this.tbSolutionFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSolutionFile.Location = new System.Drawing.Point(73, 4);
            this.tbSolutionFile.Name = "tbSolutionFile";
            this.tbSolutionFile.Size = new System.Drawing.Size(579, 20);
            this.tbSolutionFile.TabIndex = 1;
            this.tbSolutionFile.TextChanged += new System.EventHandler(this.tbSolutionFile_TextChanged);
            // 
            // bPickSolutionFile
            // 
            this.bPickSolutionFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPickSolutionFile.Location = new System.Drawing.Point(658, 2);
            this.bPickSolutionFile.Name = "bPickSolutionFile";
            this.bPickSolutionFile.Size = new System.Drawing.Size(29, 23);
            this.bPickSolutionFile.TabIndex = 2;
            this.bPickSolutionFile.Text = "...";
            this.bPickSolutionFile.UseVisualStyleBackColor = true;
            this.bPickSolutionFile.Click += new System.EventHandler(this.bPickSolutionFile_Click);
            // 
            // ofdZip
            // 
            this.ofdZip.Filter = "ZIP files|*.zip|All files|*.*";
            this.ofdZip.RestoreDirectory = true;
            this.ofdZip.Title = "Pick the managed solution file";
            // 
            // lbReplacementSitemap
            // 
            this.lbReplacementSitemap.AutoSize = true;
            this.lbReplacementSitemap.Location = new System.Drawing.Point(3, 55);
            this.lbReplacementSitemap.Name = "lbReplacementSitemap";
            this.lbReplacementSitemap.Size = new System.Drawing.Size(114, 13);
            this.lbReplacementSitemap.TabIndex = 3;
            this.lbReplacementSitemap.Text = "Replacement Sitemap:";
            // 
            // bLoadFromSolution
            // 
            this.bLoadFromSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoadFromSolution.Location = new System.Drawing.Point(303, 50);
            this.bLoadFromSolution.Name = "bLoadFromSolution";
            this.bLoadFromSolution.Size = new System.Drawing.Size(124, 23);
            this.bLoadFromSolution.TabIndex = 5;
            this.bLoadFromSolution.Text = "Load from solution";
            this.bLoadFromSolution.UseVisualStyleBackColor = true;
            this.bLoadFromSolution.Click += new System.EventHandler(this.bLoadFromSolution_Click);
            // 
            // bLoadFromFile
            // 
            this.bLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoadFromFile.Location = new System.Drawing.Point(433, 50);
            this.bLoadFromFile.Name = "bLoadFromFile";
            this.bLoadFromFile.Size = new System.Drawing.Size(124, 23);
            this.bLoadFromFile.TabIndex = 6;
            this.bLoadFromFile.Text = "Load from file";
            this.bLoadFromFile.UseVisualStyleBackColor = true;
            this.bLoadFromFile.Click += new System.EventHandler(this.bLoadFromFile_Click);
            // 
            // ofdXml
            // 
            this.ofdXml.Filter = "XML files|*.xml|All files|*.*";
            this.ofdXml.RestoreDirectory = true;
            this.ofdXml.Title = "Pick the saved sitemap file";
            // 
            // teReplacementSitemap
            // 
            this.teReplacementSitemap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teReplacementSitemap.Highlighting = null;
            this.teReplacementSitemap.Location = new System.Drawing.Point(6, 79);
            this.teReplacementSitemap.Name = "teReplacementSitemap";
            this.teReplacementSitemap.Size = new System.Drawing.Size(681, 251);
            this.teReplacementSitemap.TabIndex = 7;
            // 
            // bFix
            // 
            this.bFix.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bFix.Enabled = false;
            this.bFix.Location = new System.Drawing.Point(233, 348);
            this.bFix.Name = "bFix";
            this.bFix.Size = new System.Drawing.Size(124, 23);
            this.bFix.TabIndex = 8;
            this.bFix.Text = "Fix sitemap in solution";
            this.bFix.UseVisualStyleBackColor = true;
            this.bFix.Click += new System.EventHandler(this.bFix_Click);
            // 
            // cbCreateBackup
            // 
            this.cbCreateBackup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbCreateBackup.AutoSize = true;
            this.cbCreateBackup.Checked = true;
            this.cbCreateBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCreateBackup.Location = new System.Drawing.Point(383, 352);
            this.cbCreateBackup.Name = "cbCreateBackup";
            this.cbCreateBackup.Size = new System.Drawing.Size(105, 17);
            this.cbCreateBackup.TabIndex = 9;
            this.cbCreateBackup.Text = "Create a backup";
            this.cbCreateBackup.UseVisualStyleBackColor = true;
            // 
            // bSaveToFile
            // 
            this.bSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveToFile.Location = new System.Drawing.Point(563, 50);
            this.bSaveToFile.Name = "bSaveToFile";
            this.bSaveToFile.Size = new System.Drawing.Size(124, 23);
            this.bSaveToFile.TabIndex = 10;
            this.bSaveToFile.Text = "Save to file";
            this.bSaveToFile.UseVisualStyleBackColor = true;
            this.bSaveToFile.Click += new System.EventHandler(this.bSaveToFile_Click);
            // 
            // sfdXml
            // 
            this.sfdXml.DefaultExt = "xml";
            this.sfdXml.Filter = "XML files|*.xml|All files|*.*";
            this.sfdXml.RestoreDirectory = true;
            this.sfdXml.Title = "Save the edited sitemap to a file";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bSaveToFile);
            this.Controls.Add(this.cbCreateBackup);
            this.Controls.Add(this.bFix);
            this.Controls.Add(this.teReplacementSitemap);
            this.Controls.Add(this.bLoadFromFile);
            this.Controls.Add(this.bLoadFromSolution);
            this.Controls.Add(this.lbReplacementSitemap);
            this.Controls.Add(this.bPickSolutionFile);
            this.Controls.Add(this.tbSolutionFile);
            this.Controls.Add(this.lbSolutionFile);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(693, 379);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSolutionFile;
        private System.Windows.Forms.TextBox tbSolutionFile;
        private System.Windows.Forms.Button bPickSolutionFile;
        private System.Windows.Forms.OpenFileDialog ofdZip;
        private System.Windows.Forms.Label lbReplacementSitemap;
        private System.Windows.Forms.Button bLoadFromSolution;
        private System.Windows.Forms.Button bLoadFromFile;
        private System.Windows.Forms.OpenFileDialog ofdXml;
        private ICSharpCode.TextEditor.TextEditorControl teReplacementSitemap;
        private System.Windows.Forms.Button bFix;
        private System.Windows.Forms.CheckBox cbCreateBackup;
        private System.Windows.Forms.Button bSaveToFile;
        private System.Windows.Forms.SaveFileDialog sfdXml;
    }
}
