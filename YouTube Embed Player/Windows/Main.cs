using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace YouTubeEmbedPlayer
{
    public partial class Main : Form
    {
        private string _defaultSearch = "Search on YouTube";
        private const string YoutubeHost = "www.youtube.com";

        public bool ShowMenuStrip
        {
            get
            {
                return ui_MenuStrip.Visible;
            }

            set
            {
                ui_MenuStrip.Visible = value;
                resizeWebBrowser();
            }
        }

        public string CurrentVideoID
        {
            get
            {
                var match = Regex.Match(ui_webBrowser.Url.ToString(), @"^https?://((www|m)\.)?youtube.com/(embed/|watch\?=)([^&\?]+)");
                return match.Success ? match.Groups[4].Value : null;
            }
        }

        public bool IsOnVideo { get { return !string.IsNullOrEmpty(CurrentVideoID); } }

        public Uri CurrentVideoUri
        {
            get
            {
                return IsOnVideo ? yt("/watch?v=" + CurrentVideoID) : null;
            }
        }
        
        public Main()
        {
            InitializeComponent();
            
            ui_webBrowser.DocumentTitleChanged += UpdateWindowTitle;
            ui_webBrowser.Navigated += Navigated;
            ui_webBrowser.Navigating += Navigating;

            initSearch();
            UpdateDefaultBrowserButton();
            SetMenuCursors();            

            //string[] args = Environment.GetCommandLineArgs();
            //GoUrl(yt(args.Length >= 2 && Uri.IsWellFormedUriString(args[1], UriKind.Absolute) ? "/embed/" + args[1] : "/"));
            GoUrl(yt());
        }

        private Uri yt(string path = "/")
        {
            return new Uri("https://" + YoutubeHost + path);
        }

        private void SetMenuCursors()
        {
            foreach (ToolStripItem item in ui_MenuStrip.Items)
            {
                if (item.GetType() == typeof(ToolStripMenuItem))
                    SetCursor(item, Cursors.Hand);
            }
        }

        private void UpdateDefaultBrowserButton()
        {
            openBrowserToolStripMenuItem.Text = "";
            openBrowserToolStripMenuItem.Image = Icon.ExtractAssociatedIcon(GetSystemDefaultBrowser()).ToBitmap();
        }

        private void GoUrl(string url, Uri uri = null)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out uri))
                GoUrl(uri);
        }

        private void GoUrl(Uri uri)
        {
            ui_webBrowser.Url = uri;
        }
        
        private void UpdateWindowTitle(object sender, EventArgs e)
        {
            Text = ui_webBrowser.DocumentTitle;            
        }

        private void Navigated(object sender, EventArgs e)
        {
            UpdateWindowTitle(sender, e);
            RedirectToEmbed();
            UpdateMenuButtons();
        }

        public void Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            RedirectToEmbed(e.Url, e);
        }

        private void UpdateMenuButtons()
        {
            goBackToolStripMenuItem.Enabled = ui_webBrowser.CanGoBack;
            facebookToolStripMenuItem.Enabled = IsOnVideo;
            downloadVideoToolStripMenuItem.Enabled = IsOnVideo;
            downloadMP3ToolStripMenuItem.Enabled = IsOnVideo;

            bool isLogged = ui_webBrowser.Document.Cookie.Contains("SID=");
            youtubeLoginToolStripMenuItem.Visible = !isLogged;
            logoutToolStripMenuItem.Visible = isLogged;
        }

        private void RedirectToEmbed(Uri uri = null, WebBrowserNavigatingEventArgs e = null)
        {
            uri = uri == null ? ui_webBrowser.Url : uri;
            
            var match = Regex.Match(uri.ToString(), @"^https?://((www|m)\.)?youtube.com/watch\?v=([^&]+)?");

            if (match.Success)
            {
                ShowMenuStrip = false;
                GoUrl("https://www.youtube.com/embed/" + match.Groups[3].Value);
            }
            else
            // clean some ads
            if (Regex.IsMatch(uri.Host, @"(doubleclick\.net|2mdn\.net)$", RegexOptions.IgnoreCase))
            {
                e.Cancel = true;
            }
        }

        private void GoHome()
        {
            GoUrl(yt());
        }

        private void GoLogin()
        {
            GoUrl("https://accounts.google.com/ServiceLogin?uilel=3&service=youtube&passive=true&hl=fr&continue=https%3A%2F%2Fwww.youtube.com%2Fsignin%3Faction_handle_signin%3Dtrue%26feature%3Dsign_in_button%26app%3Ddesktop%26hl%3Dfr%26next%3D%252F#identifier");
        }

        private void GoLogout()
        {
            GoUrl(yt("/logout"));
        }

        private void GoBack()
        {
            ui_webBrowser.GoBack();
        }

        // PreviewKeyDown is called twice when not playing video, really strange
        private DateTime _WebBrowserBugBypass = DateTime.Now;
        private void ui_webBrowser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(DateTime.Now - _WebBrowserBugBypass < new TimeSpan(0, 0, 0, 0, 100))
                return;

            _WebBrowserBugBypass = DateTime.Now;

            if (e.KeyCode == Keys.F12)
                ShowMenuStrip = !ShowMenuStrip;
            else if (e.KeyCode == Keys.F11)
                GoHome();
            else if (e.KeyCode == Keys.Delete)
                GoBack();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void youtubeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLogin();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLogout();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new About().ShowDialog(this);
        }

        private void initSearch()
        {
            ui_Search.Text = _defaultSearch;
            ui_Search.ForeColor = Color.Silver;
        }

        private void ui_Search_KeyUp(object sender, KeyEventArgs e)
        {
            string search = ui_Search.Text;
                        
            if (e.KeyCode == Keys.Enter && search != "")
            {
                ShowMenuStrip = false;
                initSearch();

                GoUrl(yt("/results?search_query=" + search));
            }
        }

        private void ui_Search_Enter(object sender, EventArgs e)
        {
            if (ui_Search.Text == _defaultSearch)
            {
                ui_Search.Text = "";
                ui_Search.ForeColor = Color.Black;
            }
        }

        private void resizeWebBrowser()
        {
            ui_webBrowser.Top = ShowMenuStrip ? ui_MenuStrip.Height : 0;
            ui_webBrowser.Height = ClientSize.Height - (ShowMenuStrip ? ui_MenuStrip.Height : 0);
        }

        private void ui_Search_Leave(object sender, EventArgs e)
        {
            if (ui_Search.Text == "")
                initSearch();
        }

        private void ui_pinMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;

            ui_pinMenuItem.Image = TopMost ?
                global::YouTubeEmbedPlayer.Properties.Resources.pin_on :
                global::YouTubeEmbedPlayer.Properties.Resources.pin_off;
        }

        private void SetCursor(ToolStripItem toolStripItem, Cursor cursorOver)
        {
            toolStripItem.MouseEnter += delegate { Cursor = cursorOver; };
            toolStripItem.MouseLeave += delegate { Cursor = Cursors.Default; };
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FBShare(CurrentVideoUri).ShowDialog(this);
        }

        internal string GetSystemDefaultBrowser()
        {
            string name = string.Empty;
            RegistryKey regKey = null;

            try
            {
                //set the registry key we want to open
                regKey = Registry.ClassesRoot.OpenSubKey("HTTP\\shell\\open\\command", false);

                //get rid of the enclosing quotes
                name = regKey.GetValue(null).ToString().ToLower().Replace("" + (char)34, "");

                //check to see if the value ends with .exe (this way we can remove any command line arguments)
                if (!name.EndsWith("exe"))
                    //get rid of all command line arguments (anything after the .exe must go)
                    name = name.Substring(0, name.LastIndexOf(".exe") + 4);

            }
            catch (Exception ex)
            {
                name = string.Format("ERROR: An exception of type: {0} occurred in method: {1} in the following module: {2}", ex.GetType(), ex.TargetSite, this.GetType());
            }
            finally
            {
                //check and see if the key is still open, if so
                //then close it
                if (regKey != null)
                    regKey.Close();
            }
            //return the value
            return name;

        }

        private void openBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start((IsOnVideo ? CurrentVideoUri : ui_webBrowser.Url).ToString());
        }

        private void downloadVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(CurrentVideoUri.ToString().Replace("youtube.com", "youtube1s.com"));
        }

        private void downloadMP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(CurrentVideoUri.ToString().Replace("youtube.com", "sonyoutube.com"));
        }
    }
}
