namespace BcInstaller.Forms.Installer
{
    partial class DownloadAssetsForm
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
            this.pbCurrent = new System.Windows.Forms.ProgressBar();
            this.pbTotal = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbHash = new System.Windows.Forms.Label();
            this.lbFileSize = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbiPath = new System.Windows.Forms.Label();
            this.lbiHash = new System.Windows.Forms.Label();
            this.lbiFileSize = new System.Windows.Forms.Label();
            this.lbiFileName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCurrent
            // 
            this.pbCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCurrent.Location = new System.Drawing.Point(12, 129);
            this.pbCurrent.Name = "pbCurrent";
            this.pbCurrent.Size = new System.Drawing.Size(367, 23);
            this.pbCurrent.Step = 1;
            this.pbCurrent.TabIndex = 0;
            // 
            // pbTotal
            // 
            this.pbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTotal.Location = new System.Drawing.Point(12, 158);
            this.pbTotal.Name = "pbTotal";
            this.pbTotal.Size = new System.Drawing.Size(367, 23);
            this.pbTotal.Step = 1;
            this.pbTotal.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbPath);
            this.groupBox1.Controls.Add(this.lbHash);
            this.groupBox1.Controls.Add(this.lbFileSize);
            this.groupBox1.Controls.Add(this.lbFileName);
            this.groupBox1.Controls.Add(this.lbiPath);
            this.groupBox1.Controls.Add(this.lbiHash);
            this.groupBox1.Controls.Add(this.lbiFileSize);
            this.groupBox1.Controls.Add(this.lbiFileName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbPath
            // 
            this.lbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPath.AutoEllipsis = true;
            this.lbPath.Location = new System.Drawing.Point(88, 73);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(266, 20);
            this.lbPath.TabIndex = 7;
            // 
            // lbHash
            // 
            this.lbHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHash.AutoEllipsis = true;
            this.lbHash.Location = new System.Drawing.Point(88, 56);
            this.lbHash.Name = "lbHash";
            this.lbHash.Size = new System.Drawing.Size(266, 20);
            this.lbHash.TabIndex = 6;
            // 
            // lbFileSize
            // 
            this.lbFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFileSize.AutoEllipsis = true;
            this.lbFileSize.Location = new System.Drawing.Point(88, 38);
            this.lbFileSize.Name = "lbFileSize";
            this.lbFileSize.Size = new System.Drawing.Size(266, 20);
            this.lbFileSize.TabIndex = 5;
            // 
            // lbFileName
            // 
            this.lbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFileName.AutoEllipsis = true;
            this.lbFileName.Location = new System.Drawing.Point(88, 19);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(266, 20);
            this.lbFileName.TabIndex = 4;
            // 
            // lbiPath
            // 
            this.lbiPath.AutoSize = true;
            this.lbiPath.Location = new System.Drawing.Point(15, 73);
            this.lbiPath.Name = "lbiPath";
            this.lbiPath.Size = new System.Drawing.Size(67, 17);
            this.lbiPath.TabIndex = 3;
            this.lbiPath.Text = "Caminho:";
            // 
            // lbiHash
            // 
            this.lbiHash.AutoSize = true;
            this.lbiHash.Location = new System.Drawing.Point(39, 56);
            this.lbiHash.Name = "lbiHash";
            this.lbiHash.Size = new System.Drawing.Size(43, 17);
            this.lbiHash.TabIndex = 2;
            this.lbiHash.Text = "Hash:";
            // 
            // lbiFileSize
            // 
            this.lbiFileSize.AutoSize = true;
            this.lbiFileSize.Location = new System.Drawing.Point(11, 39);
            this.lbiFileSize.Name = "lbiFileSize";
            this.lbiFileSize.Size = new System.Drawing.Size(71, 17);
            this.lbiFileSize.TabIndex = 1;
            this.lbiFileSize.Text = "Tamanho:";
            // 
            // lbiFileName
            // 
            this.lbiFileName.AutoSize = true;
            this.lbiFileName.Location = new System.Drawing.Point(33, 20);
            this.lbiFileName.Name = "lbiFileName";
            this.lbiFileName.Size = new System.Drawing.Size(49, 17);
            this.lbiFileName.TabIndex = 0;
            this.lbiFileName.Text = "Nome:";
            // 
            // DownloadAssetsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(391, 193);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbTotal);
            this.Controls.Add(this.pbCurrent);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadAssetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BC: Transferindo Recursos";
            this.Load += new System.EventHandler(this.DownloadAssetsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbCurrent;
        private System.Windows.Forms.ProgressBar pbTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbiFileSize;
        private System.Windows.Forms.Label lbiFileName;
        private System.Windows.Forms.Label lbiHash;
        private System.Windows.Forms.Label lbiPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbHash;
        private System.Windows.Forms.Label lbFileSize;
        private System.Windows.Forms.Label lbFileName;
    }
}