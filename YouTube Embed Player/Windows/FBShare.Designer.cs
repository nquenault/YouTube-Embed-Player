namespace YouTubeEmbedPlayer
{
    partial class FBShare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBShare));
            this.ui_webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ui_webBrowser
            // 
            this.ui_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_webBrowser.Location = new System.Drawing.Point(0, 0);
            this.ui_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ui_webBrowser.Name = "ui_webBrowser";
            this.ui_webBrowser.ScriptErrorsSuppressed = true;
            this.ui_webBrowser.ScrollBarsEnabled = false;
            this.ui_webBrowser.Size = new System.Drawing.Size(591, 557);
            this.ui_webBrowser.TabIndex = 0;
            // 
            // FBShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 557);
            this.Controls.Add(this.ui_webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FBShare";
            this.Text = "Facebook Share";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ui_webBrowser;
    }
}