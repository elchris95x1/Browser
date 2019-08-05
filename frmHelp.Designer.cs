namespace Lara_Media
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.mplDemo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.mplDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // mplDemo
            // 
            this.mplDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mplDemo.Enabled = true;
            this.mplDemo.Location = new System.Drawing.Point(0, -1);
            this.mplDemo.Name = "mplDemo";
            this.mplDemo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mplDemo.OcxState")));
            this.mplDemo.Size = new System.Drawing.Size(284, 256);
            this.mplDemo.TabIndex = 0;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.mplDemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHelp_FormClosing);
            this.Load += new System.EventHandler(this.frmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mplDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer mplDemo;
    }
}