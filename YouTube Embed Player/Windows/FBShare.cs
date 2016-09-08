using System;
using System.Windows.Forms;

namespace YouTubeEmbedPlayer
{
    public partial class FBShare : Form
    {
        public FBShare(Uri uri)
        {
            InitializeComponent();

            ui_webBrowser.Navigating += Navigating;

            string url = "https://www.facebook.com/sharer/sharer.php?u=" + uri.ToString();
            ui_webBrowser.Url = new Uri(url);
        }

        public void Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.AbsolutePath == "/dialog/return/close")
            {
                e.Cancel = true;
                Close();
            }
        }
    }
}
