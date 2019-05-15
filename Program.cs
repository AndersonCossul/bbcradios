using System;
using System.Windows.Forms;

namespace BBCRadios
{
    static class Program
    {
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// Starts playing resource with WindowsMediaPlayer
        /// </summary>
        public static void PlayMusicFromURL(string url)
        {
            player.URL = url;
            player.settings.volume = 100;
            player.controls.play();
        }

        /// <summary>
        /// Stops playing resource with WindowsMediaPlayer
        /// </summary>
        public static void StopPlayer()
        {
            player.controls.stop();
        }
    }
}
