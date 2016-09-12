using System;
﻿using System.Windows.Forms;
﻿namespace YouTubeEmbedPlayer
{
    partial class Main
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ui_webBrowser = new System.Windows.Forms.WebBrowser();
            this.ui_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripVerticalSeparator1 = new System.Windows.Forms.ToolStripLabel();
            this.goHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripVerticalSeparator2 = new System.Windows.Forms.ToolStripLabel();
            this.ui_Search = new System.Windows.Forms.ToolStripTextBox();
            this.menuStripVerticalSeparator3 = new System.Windows.Forms.ToolStripLabel();
            this.menuStripLabelItem = new System.Windows.Forms.ToolStripLabel();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_pinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadMP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeVidPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_webBrowser
            // 
            this.ui_webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_webBrowser.Location = new System.Drawing.Point(0, 27);
            this.ui_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ui_webBrowser.Name = "ui_webBrowser";
            this.ui_webBrowser.ScriptErrorsSuppressed = true;
            this.ui_webBrowser.Size = new System.Drawing.Size(1174, 576);
            this.ui_webBrowser.TabIndex = 0;
            this.ui_webBrowser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ui_webBrowser_PreviewKeyDown);
            // 
            // ui_MenuStrip
            // 
            this.ui_MenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.menuStripVerticalSeparator1,
            this.goHomeToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.youtubeLoginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.menuStripVerticalSeparator2,
            this.ui_Search,
            this.menuStripVerticalSeparator3,
            this.menuStripLabelItem,
            this.aboutToolStripMenuItem1,
            this.ui_pinMenuItem,
            this.facebookToolStripMenuItem,
            this.downloadVideoToolStripMenuItem,
            this.downloadMP3ToolStripMenuItem,
            this.youtubeVidPageToolStripMenuItem,
            this.openBrowserToolStripMenuItem});
            this.ui_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ui_MenuStrip.Name = "ui_MenuStrip";
            this.ui_MenuStrip.ShowItemToolTips = true;
            this.ui_MenuStrip.Size = new System.Drawing.Size(1174, 27);
            this.ui_MenuStrip.TabIndex = 1;
            this.ui_MenuStrip.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.exitToolStripMenuItem.ToolTipText = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStripVerticalSeparator1
            // 
            this.menuStripVerticalSeparator1.Name = "menuStripVerticalSeparator1";
            this.menuStripVerticalSeparator1.Size = new System.Drawing.Size(10, 20);
            this.menuStripVerticalSeparator1.Text = "|";
            // 
            // goHomeToolStripMenuItem
            // 
            this.goHomeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("goHomeToolStripMenuItem.Image")));
            this.goHomeToolStripMenuItem.Name = "goHomeToolStripMenuItem";
            this.goHomeToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.goHomeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.goHomeToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.goHomeToolStripMenuItem.Text = "Home (F11)";
            this.goHomeToolStripMenuItem.ToolTipText = "YouTube Home";
            this.goHomeToolStripMenuItem.Click += new System.EventHandler(this.goHomeToolStripMenuItem_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Enabled = false;
            this.goBackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("goBackToolStripMenuItem.Image")));
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.goBackToolStripMenuItem.Text = "Back";
            this.goBackToolStripMenuItem.ToolTipText = "Go back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // youtubeLoginToolStripMenuItem
            // 
            this.youtubeLoginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("youtubeLoginToolStripMenuItem.Image")));
            this.youtubeLoginToolStripMenuItem.Name = "youtubeLoginToolStripMenuItem";
            this.youtubeLoginToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.youtubeLoginToolStripMenuItem.Text = "Login";
            this.youtubeLoginToolStripMenuItem.ToolTipText = "Login to YouTube";
            this.youtubeLoginToolStripMenuItem.Click += new System.EventHandler(this.youtubeLoginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.ToolTipText = "Logout from YouTube";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuStripVerticalSeparator2
            // 
            this.menuStripVerticalSeparator2.Name = "menuStripVerticalSeparator2";
            this.menuStripVerticalSeparator2.Size = new System.Drawing.Size(10, 20);
            this.menuStripVerticalSeparator2.Text = "|";
            // 
            // ui_Search
            // 
            this.ui_Search.ForeColor = System.Drawing.Color.Silver;
            this.ui_Search.Name = "ui_Search";
            this.ui_Search.Size = new System.Drawing.Size(200, 23);
            this.ui_Search.Text = "Search";
            this.ui_Search.Enter += new System.EventHandler(this.ui_Search_Enter);
            this.ui_Search.Leave += new System.EventHandler(this.ui_Search_Leave);
            this.ui_Search.LostFocus += new System.EventHandler(this.ui_Search_Leave);
            this.ui_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ui_Search_KeyUp);
            // 
            // menuStripVerticalSeparator3
            // 
            this.menuStripVerticalSeparator3.Name = "menuStripVerticalSeparator3";
            this.menuStripVerticalSeparator3.Size = new System.Drawing.Size(10, 20);
            this.menuStripVerticalSeparator3.Text = "|";
            // 
            // menuStripLabelItem
            // 
            this.menuStripLabelItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripLabelItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.menuStripLabelItem.Name = "menuStripLabelItem";
            this.menuStripLabelItem.Size = new System.Drawing.Size(263, 20);
            this.menuStripLabelItem.Text = "Press F12 to switch hide and show this menu ;)";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem1.Image")));
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(28, 23);
            this.aboutToolStripMenuItem1.ToolTipText = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // ui_pinMenuItem
            // 
            this.ui_pinMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ui_pinMenuItem.Image = global::YouTubeEmbedPlayer.Properties.Resources.pin_off;
            this.ui_pinMenuItem.Name = "ui_pinMenuItem";
            this.ui_pinMenuItem.Size = new System.Drawing.Size(28, 23);
            this.ui_pinMenuItem.ToolTipText = "Always on top";
            this.ui_pinMenuItem.Click += new System.EventHandler(this.ui_pinMenuItem_Click);
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.facebookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facebookToolStripMenuItem.Image")));
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.facebookToolStripMenuItem.ToolTipText = "Share on Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // downloadVideoToolStripMenuItem
            // 
            this.downloadVideoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.downloadVideoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadVideoToolStripMenuItem.Image")));
            this.downloadVideoToolStripMenuItem.Name = "downloadVideoToolStripMenuItem";
            this.downloadVideoToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.downloadVideoToolStripMenuItem.ToolTipText = "Download video";
            this.downloadVideoToolStripMenuItem.Click += new System.EventHandler(this.downloadVideoToolStripMenuItem_Click);
            // 
            // downloadMP3ToolStripMenuItem
            // 
            this.downloadMP3ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.downloadMP3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadMP3ToolStripMenuItem.Image")));
            this.downloadMP3ToolStripMenuItem.Name = "downloadMP3ToolStripMenuItem";
            this.downloadMP3ToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.downloadMP3ToolStripMenuItem.ToolTipText = "Download sound";
            this.downloadMP3ToolStripMenuItem.Click += new System.EventHandler(this.downloadMP3ToolStripMenuItem_Click);
            // 
            // openBrowserToolStripMenuItem
            // 
            this.openBrowserToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.openBrowserToolStripMenuItem.Name = "openBrowserToolStripMenuItem";
            this.openBrowserToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.openBrowserToolStripMenuItem.Text = "OpenBrowser";
            this.openBrowserToolStripMenuItem.ToolTipText = "Open in browser";
            this.openBrowserToolStripMenuItem.Click += new System.EventHandler(this.openBrowserToolStripMenuItem_Click);
            // 
            // youtubeVidPageToolStripMenuItem
            // 
            this.youtubeVidPageToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.youtubeVidPageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("youtubeVidPageToolStripMenuItem.Image")));
            this.youtubeVidPageToolStripMenuItem.Name = "youtubeVidPageToolStripMenuItem";
            this.youtubeVidPageToolStripMenuItem.Size = new System.Drawing.Size(28, 23);
            this.youtubeVidPageToolStripMenuItem.ToolTipText = "Go to source page";
            this.youtubeVidPageToolStripMenuItem.Click += new System.EventHandler(this.youtubeVidPageToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 603);
            this.Controls.Add(this.ui_MenuStrip);
            this.Controls.Add(this.ui_webBrowser);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.ui_MenuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "YouTube Embed Player";
            this.ui_MenuStrip.ResumeLayout(false);
            this.ui_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser ui_webBrowser;
        private System.Windows.Forms.MenuStrip ui_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem goHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel menuStripLabelItem;
        private System.Windows.Forms.ToolStripLabel menuStripVerticalSeparator1;
        private System.Windows.Forms.ToolStripLabel menuStripVerticalSeparator2;
        private System.Windows.Forms.ToolStripLabel menuStripVerticalSeparator3;
        private System.Windows.Forms.ToolStripTextBox ui_Search;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ui_pinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadMP3ToolStripMenuItem;
        private ToolStripMenuItem youtubeVidPageToolStripMenuItem;
    }
}

