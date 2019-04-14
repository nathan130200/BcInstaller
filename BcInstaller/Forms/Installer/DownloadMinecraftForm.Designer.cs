namespace BcInstaller.Forms.Installer
{
    partial class DownloadMinecraftForm
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
            this.lbDesc = new System.Windows.Forms.Label();
            this.pbTotal = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbDesc
            // 
            this.lbDesc.AutoEllipsis = true;
            this.lbDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDesc.Location = new System.Drawing.Point(0, 0);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbDesc.Size = new System.Drawing.Size(393, 53);
            this.lbDesc.TabIndex = 0;
            this.lbDesc.Text = "[1/4]: Tarefa: Procurar manifesto...";
            this.lbDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbTotal
            // 
            this.pbTotal.Location = new System.Drawing.Point(12, 56);
            this.pbTotal.Maximum = 4;
            this.pbTotal.Name = "pbTotal";
            this.pbTotal.Size = new System.Drawing.Size(369, 23);
            this.pbTotal.Step = 1;
            this.pbTotal.TabIndex = 2;
            // 
            // DownloadMinecraftForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(393, 88);
            this.ControlBox = false;
            this.Controls.Add(this.pbTotal);
            this.Controls.Add(this.lbDesc);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadMinecraftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BC: Transferindo Minecraft.";
            this.Load += new System.EventHandler(this.DownloadMinecraftForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.ProgressBar pbTotal;
    }
}