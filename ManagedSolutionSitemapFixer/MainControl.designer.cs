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
            this.rtbReplacementSitemap = new System.Windows.Forms.RichTextBox();
            this.bLoadFromSolution = new System.Windows.Forms.Button();
            this.bLoadFromFile = new System.Windows.Forms.Button();
            this.ofdXml = new System.Windows.Forms.OpenFileDialog();
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
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
            this.ofdZip.FileName = "openFileDialog";
            this.ofdZip.Filter = "ZIP files|*.zip|All files|*.*";
            this.ofdZip.RestoreDirectory = true;
            // 
            // lbReplacementSitemap
            // 
            this.lbReplacementSitemap.AutoSize = true;
            this.lbReplacementSitemap.Location = new System.Drawing.Point(3, 50);
            this.lbReplacementSitemap.Name = "lbReplacementSitemap";
            this.lbReplacementSitemap.Size = new System.Drawing.Size(114, 13);
            this.lbReplacementSitemap.TabIndex = 3;
            this.lbReplacementSitemap.Text = "Replacement Sitemap:";
            // 
            // rtbReplacementSitemap
            // 
            this.rtbReplacementSitemap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbReplacementSitemap.Location = new System.Drawing.Point(6, 75);
            this.rtbReplacementSitemap.Name = "rtbReplacementSitemap";
            this.rtbReplacementSitemap.Size = new System.Drawing.Size(681, 83);
            this.rtbReplacementSitemap.TabIndex = 4;
            this.rtbReplacementSitemap.Text = "";
            // 
            // bLoadFromSolution
            // 
            this.bLoadFromSolution.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bLoadFromSolution.Location = new System.Drawing.Point(433, 50);
            this.bLoadFromSolution.Name = "bLoadFromSolution";
            this.bLoadFromSolution.Size = new System.Drawing.Size(124, 23);
            this.bLoadFromSolution.TabIndex = 5;
            this.bLoadFromSolution.Text = "Load from solution";
            this.bLoadFromSolution.UseVisualStyleBackColor = true;
            this.bLoadFromSolution.Click += new System.EventHandler(this.bLoadFromSolution_Click);
            // 
            // bLoadFromFile
            // 
            this.bLoadFromFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bLoadFromFile.Location = new System.Drawing.Point(563, 50);
            this.bLoadFromFile.Name = "bLoadFromFile";
            this.bLoadFromFile.Size = new System.Drawing.Size(124, 23);
            this.bLoadFromFile.TabIndex = 6;
            this.bLoadFromFile.Text = "Load from file";
            this.bLoadFromFile.UseVisualStyleBackColor = true;
            this.bLoadFromFile.Click += new System.EventHandler(this.bLoadFromFile_Click);
            // 
            // ofdXml
            // 
            this.ofdXml.FileName = "openFileDialog";
            this.ofdXml.Filter = "XML files|*.xml|All files|*.*";
            this.ofdXml.RestoreDirectory = true;
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorControl1.Highlighting = null;
            this.textEditorControl1.Location = new System.Drawing.Point(6, 164);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(681, 201);
            this.textEditorControl1.TabIndex = 7;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEditorControl1);
            this.Controls.Add(this.bLoadFromFile);
            this.Controls.Add(this.bLoadFromSolution);
            this.Controls.Add(this.rtbReplacementSitemap);
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
        private System.Windows.Forms.RichTextBox rtbReplacementSitemap;
        private System.Windows.Forms.Button bLoadFromSolution;
        private System.Windows.Forms.Button bLoadFromFile;
        private System.Windows.Forms.OpenFileDialog ofdXml;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
    }
}
