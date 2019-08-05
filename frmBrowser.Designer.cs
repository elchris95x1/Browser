namespace Lara_Media
{
    partial class frmBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.brgBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tsToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.tabMainTab = new System.Windows.Forms.TabControl();
            this.lblNewTab = new System.Windows.Forms.Label();
            this.lblCloseTab = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.ttFrmTips = new System.Windows.Forms.ToolTip(this.components);
            this.ssStatusStrip.SuspendLayout();
            this.tsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(145, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(680, 20);
            this.txtURL.TabIndex = 1;
            this.ttFrmTips.SetToolTip(this.txtURL, "Url");
            this.txtURL.Enter += new System.EventHandler(this.txtURL_Enter);
            this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtURL_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(831, 11);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(37, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.ttFrmTips.SetToolTip(this.btnGo, "Navigate");
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tspProgressBar});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 497);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(880, 22);
            this.ssStatusStrip.TabIndex = 4;
            this.ssStatusStrip.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(66, 17);
            this.tssStatus.Text = "This is fine!";
            // 
            // tspProgressBar
            // 
            this.tspProgressBar.Name = "tspProgressBar";
            this.tspProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tsToolStrip
            // 
            this.tsToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.tsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOptions,
            this.tsbPrevious,
            this.tsbNext,
            this.tsbHome,
            this.tsbReload});
            this.tsToolStrip.Location = new System.Drawing.Point(9, 9);
            this.tsToolStrip.Name = "tsToolStrip";
            this.tsToolStrip.Size = new System.Drawing.Size(133, 25);
            this.tsToolStrip.TabIndex = 5;
            // 
            // tsbOptions
            // 
            this.tsbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHistory,
            this.mnuHelp,
            this.mnuExit});
            this.tsbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptions.Image")));
            this.tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptions.Name = "tsbOptions";
            this.tsbOptions.Size = new System.Drawing.Size(29, 22);
            this.tsbOptions.Text = "toolStripDropDownButton1";
            this.tsbOptions.ToolTipText = "options";
            // 
            // mnuHistory
            // 
            this.mnuHistory.Name = "mnuHistory";
            this.mnuHistory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuHistory.Size = new System.Drawing.Size(155, 22);
            this.mnuHistory.Text = "History";
            this.mnuHistory.ToolTipText = "Browser history";
            this.mnuHistory.Click += new System.EventHandler(this.mnuHistory_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.mnuHelp.Size = new System.Drawing.Size(155, 22);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.ToolTipText = "Help Using application";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(155, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.ToolTipText = "exit application";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // tsbPrevious
            // 
            this.tsbPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrevious.Image")));
            this.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrevious.Name = "tsbPrevious";
            this.tsbPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsbPrevious.Text = "toolStripButton1";
            this.tsbPrevious.ToolTipText = "previous webpage";
            this.tsbPrevious.Click += new System.EventHandler(this.tsbPrevious_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(23, 22);
            this.tsbNext.Text = "toolStripButton2";
            this.tsbNext.ToolTipText = "next webpage";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbHome
            // 
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.Image = ((System.Drawing.Image)(resources.GetObject("tsbHome.Image")));
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(23, 22);
            this.tsbHome.Text = "toolStripButton3";
            this.tsbHome.ToolTipText = "Home";
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.Image = ((System.Drawing.Image)(resources.GetObject("tsbReload.Image")));
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(23, 22);
            this.tsbReload.Text = "toolStripButton4";
            this.tsbReload.ToolTipText = "reload";
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // tabMainTab
            // 
            this.tabMainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMainTab.Location = new System.Drawing.Point(0, 49);
            this.tabMainTab.Name = "tabMainTab";
            this.tabMainTab.SelectedIndex = 0;
            this.tabMainTab.Size = new System.Drawing.Size(880, 445);
            this.tabMainTab.TabIndex = 6;
            this.tabMainTab.SelectedIndexChanged += new System.EventHandler(this.tabMainTab_SelectedIndexChanged);
            // 
            // lblNewTab
            // 
            this.lblNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewTab.AutoSize = true;
            this.lblNewTab.Location = new System.Drawing.Point(828, 37);
            this.lblNewTab.Name = "lblNewTab";
            this.lblNewTab.Size = new System.Drawing.Size(13, 13);
            this.lblNewTab.TabIndex = 10;
            this.lblNewTab.Text = "+";
            this.ttFrmTips.SetToolTip(this.lblNewTab, "New tab");
            this.lblNewTab.Click += new System.EventHandler(this.lblNewTab_Click);
            // 
            // lblCloseTab
            // 
            this.lblCloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseTab.AutoSize = true;
            this.lblCloseTab.Location = new System.Drawing.Point(854, 37);
            this.lblCloseTab.Name = "lblCloseTab";
            this.lblCloseTab.Size = new System.Drawing.Size(14, 13);
            this.lblCloseTab.TabIndex = 11;
            this.lblCloseTab.Text = "X";
            this.ttFrmTips.SetToolTip(this.lblCloseTab, "Close current tab");
            this.lblCloseTab.Click += new System.EventHandler(this.lblCloseTab_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "reload.png");
            this.imageList.Images.SetKeyName(1, "cancel.png");
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 519);
            this.Controls.Add(this.lblCloseTab);
            this.Controls.Add(this.lblNewTab);
            this.Controls.Add(this.tabMainTab);
            this.Controls.Add(this.tsToolStrip);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.Text = "Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBrowser_FormClosing);
            this.Load += new System.EventHandler(this.frmBrowser_Load);
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.tsToolStrip.ResumeLayout(false);
            this.tsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripProgressBar tspProgressBar;
        private System.ComponentModel.BackgroundWorker brgBackgroundWorker;
        private System.Windows.Forms.ToolStrip tsToolStrip;
        private System.Windows.Forms.ToolStripButton tsbPrevious;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.ToolStripDropDownButton tsbOptions;
        private System.Windows.Forms.TabControl tabMainTab;
        private System.Windows.Forms.Label lblNewTab;
        private System.Windows.Forms.Label lblCloseTab;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripMenuItem mnuHistory;
        public System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ToolTip ttFrmTips;
    }
}

