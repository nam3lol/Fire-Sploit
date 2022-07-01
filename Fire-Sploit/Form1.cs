using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Sploit
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        void LoadApps()
        {
            //loadapps code written by the one and only syron
            if (File.Exists("./bin/Apps/FPS_Unlocker.exe"))
            {

            }
            else
            {
                WebClient wc = new WebClient();
                if (File.Exists("./bin/Apps/FPS_Unlocker.exe"))
                {
                    if (Directory.Exists("./bin/"))
                    {
                        string FpsUnlocker = "https://pastebin.com/raw/YERKAVqm";
                        string FpsUnlockerString = wc.DownloadString(FpsUnlocker);
                        wc.DownloadFile(FpsUnlockerString, "./bin/Apps/FPS_Unlocker.exe");
                    }
                    else
                    {
                        Directory.CreateDirectory("./bin");
                        Directory.CreateDirectory("./bin/Apps");
                        string FpsUnlocker = "https://pastebin.com/raw/YERKAVqm";
                        string FpsUnlockerString = wc.DownloadString(FpsUnlocker);
                        wc.DownloadFile(FpsUnlockerString, "./bin/Apps/FPS_Unlocker.exe");
                    }
                }
                else
                {
                    if (Directory.Exists("./bin/"))
                    {
                        string FpsUnlocker = "https://pastebin.com/raw/YERKAVqm";
                        string FpsUnlockerString = wc.DownloadString(FpsUnlocker);
                        wc.DownloadFile(FpsUnlockerString, "./bin/Apps/FPS_Unlocker.exe");
                    }
                    else
                    {
                        Directory.CreateDirectory("./bin");
                        Directory.CreateDirectory("./bin/Apps");
                        string FpsUnlocker = "https://pastebin.com/raw/YERKAVqm";
                        string FpsUnlockerString = wc.DownloadString(FpsUnlocker);
                        wc.DownloadFile(FpsUnlockerString, "./bin/Apps/FPS_Unlocker.exe");
                    }
                }
            }
        }

        private async void Loader_Load(object sender, EventArgs e)
        {
            //easy load code, make sure to read the syntax and not paste :kekw:
            QuoteLbl.Text = " atari needs vouch";
            StatusLbl.Text = "          Downloading Apps";
            LoadApps();
            ProgressBar.Value = 60;
            await Task.Delay(1000);
            StatusLbl.Text = "Preloading Windows";
            ProgressBar.Value = 90;
            await Task.Delay(1000);
            ProgressBar.Value = 100;
            if (MessageBox.Show("Thanks For Using Fire-Sploit! Have Fun.", "Fire-Sploit", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ExecutorForm execForm = new ExecutorForm();
                execForm.Show();
                this.Hide();
            }

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //exits the enviroments apps aka the whole application
        }
    }
}
