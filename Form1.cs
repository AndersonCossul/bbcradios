using System;
using System.Windows.Forms;

namespace BBCRadios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Program.StopPlayer();
            btnStop.Enabled = false;
            lblPlaying.Visible = false;
        }

        private void startPlaying(string url)
        {
            Program.PlayMusicFromURL(url);
            btnStop.Enabled = true;
            lblPlaying.Visible = true;
        }

        private void BtnRadio4_Click(object sender, EventArgs e)
        {
            startPlaying("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio4fm_mf_p");
        }
    }
}
