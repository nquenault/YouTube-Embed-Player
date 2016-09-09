using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace YouTubeEmbedPlayer
{
    public partial class About : Form
    {
        private System.Version CurrentVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }

        public About()
        {
            InitializeComponent();

            string version = CurrentVersion.Major.ToString() + "." + CurrentVersion.Minor.ToString();

            if (CurrentVersion.Build != 0)
                version += "." + CurrentVersion.Build.ToString();

            if (CurrentVersion.Revision != 0)
                version += "." + CurrentVersion.Revision.ToString();
            
            ui_Version.Text = "version " + version;
        }

        private void ui_WebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ui_WebsiteLink.Text);
        }
    }
}
