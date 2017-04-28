namespace Winforms_exercices
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFichProj = new System.Windows.Forms.CheckBox();
            this.chkFichLong = new System.Windows.Forms.CheckBox();
            this.chkFichCs = new System.Windows.Forms.CheckBox();
            this.chkTotFichier = new System.Windows.Forms.CheckBox();
            this.btnAnalyser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.btnfolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotFichier = new System.Windows.Forms.Label();
            this.lbFichCs = new System.Windows.Forms.Label();
            this.lbFichLon = new System.Windows.Forms.Label();
            this.listBFich = new System.Windows.Forms.ListBox();
            this.lbValFichLon = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFichProj);
            this.groupBox1.Controls.Add(this.chkFichLong);
            this.groupBox1.Controls.Add(this.chkFichCs);
            this.groupBox1.Controls.Add(this.chkTotFichier);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkFichProj
            // 
            resources.ApplyResources(this.chkFichProj, "chkFichProj");
            this.chkFichProj.Checked = global::Winforms_exercices.Properties.Settings.Default.ListFichPro;
            this.chkFichProj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFichProj.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Winforms_exercices.Properties.Settings.Default, "ListFichPro", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkFichProj.Name = "chkFichProj";
            this.chkFichProj.UseVisualStyleBackColor = true;
            // 
            // chkFichLong
            // 
            resources.ApplyResources(this.chkFichLong, "chkFichLong");
            this.chkFichLong.Checked = global::Winforms_exercices.Properties.Settings.Default.NbFichLon;
            this.chkFichLong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFichLong.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Winforms_exercices.Properties.Settings.Default, "NbFichLon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkFichLong.Name = "chkFichLong";
            this.chkFichLong.UseVisualStyleBackColor = true;
            // 
            // chkFichCs
            // 
            resources.ApplyResources(this.chkFichCs, "chkFichCs");
            this.chkFichCs.Checked = global::Winforms_exercices.Properties.Settings.Default.nbFichCs;
            this.chkFichCs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFichCs.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Winforms_exercices.Properties.Settings.Default, "nbFichCs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkFichCs.Name = "chkFichCs";
            this.chkFichCs.UseVisualStyleBackColor = true;
            // 
            // chkTotFichier
            // 
            resources.ApplyResources(this.chkTotFichier, "chkTotFichier");
            this.chkTotFichier.Checked = global::Winforms_exercices.Properties.Settings.Default.nbTotFi;
            this.chkTotFichier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTotFichier.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Winforms_exercices.Properties.Settings.Default, "nbTotFi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTotFichier.Name = "chkTotFichier";
            this.chkTotFichier.UseVisualStyleBackColor = true;
            // 
            // btnAnalyser
            // 
            resources.ApplyResources(this.btnAnalyser, "btnAnalyser");
            this.btnAnalyser.Name = "btnAnalyser";
            this.btnAnalyser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbFolder
            // 
            resources.ApplyResources(this.tbFolder, "tbFolder");
            this.tbFolder.Name = "tbFolder";
            // 
            // btnfolder
            // 
            resources.ApplyResources(this.btnfolder, "btnfolder");
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbTotFichier
            // 
            resources.ApplyResources(this.lbTotFichier, "lbTotFichier");
            this.lbTotFichier.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTotFichier.Name = "lbTotFichier";
            // 
            // lbFichCs
            // 
            resources.ApplyResources(this.lbFichCs, "lbFichCs");
            this.lbFichCs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbFichCs.Name = "lbFichCs";
            // 
            // lbFichLon
            // 
            resources.ApplyResources(this.lbFichLon, "lbFichLon");
            this.lbFichLon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbFichLon.Name = "lbFichLon";
            // 
            // listBFich
            // 
            this.listBFich.FormattingEnabled = true;
            this.listBFich.Items.AddRange(new object[] {
            resources.GetString("listBFich.Items"),
            resources.GetString("listBFich.Items1"),
            resources.GetString("listBFich.Items2")});
            resources.ApplyResources(this.listBFich, "listBFich");
            this.listBFich.Name = "listBFich";
            // 
            // lbValFichLon
            // 
            resources.ApplyResources(this.lbValFichLon, "lbValFichLon");
            this.lbValFichLon.Name = "lbValFichLon";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbValFichLon);
            this.Controls.Add(this.listBFich);
            this.Controls.Add(this.lbFichLon);
            this.Controls.Add(this.lbFichCs);
            this.Controls.Add(this.lbTotFichier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalyser);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFichProj;
        private System.Windows.Forms.CheckBox chkFichLong;
        private System.Windows.Forms.CheckBox chkFichCs;
        private System.Windows.Forms.CheckBox chkTotFichier;
        private System.Windows.Forms.Button btnAnalyser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotFichier;
        private System.Windows.Forms.Label lbFichCs;
        private System.Windows.Forms.Label lbFichLon;
        private System.Windows.Forms.ListBox listBFich;
        private System.Windows.Forms.Label lbValFichLon;
    }
}

