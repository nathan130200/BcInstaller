namespace BcInstaller
{
    partial class SplashForm
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
            this.lbMain = new System.Windows.Forms.Label();
            this.pbMarquee = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.Location = new System.Drawing.Point(0, 0);
            this.lbMain.Name = "lbMain";
            this.lbMain.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbMain.Size = new System.Drawing.Size(226, 74);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "VERIFICANDO...";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbMarquee
            // 
            this.pbMarquee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMarquee.Location = new System.Drawing.Point(12, 37);
            this.pbMarquee.MarqueeAnimationSpeed = 50;
            this.pbMarquee.Name = "pbMarquee";
            this.pbMarquee.Size = new System.Drawing.Size(202, 25);
            this.pbMarquee.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbMarquee.TabIndex = 1;
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(226, 74);
            this.Controls.Add(this.pbMarquee);
            this.Controls.Add(this.lbMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Craft";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.ProgressBar pbMarquee;
    }
}

