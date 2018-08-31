using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace LAUNCHER
{
    public partial class Readme : Form
    {
        public Readme()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;

            textBox1.AppendText("AvP2 Launcher 1.x:" + Environment.NewLine);
            textBox1.AppendText("Created by: ..." + Environment.NewLine);
            textBox1.AppendText("--------------------------------------------------------------" + Environment.NewLine);
            textBox1.AppendText(" " + Environment.NewLine);
            textBox1.AppendText("This launcher was created for and by the AvP2 community." + Environment.NewLine);
            textBox1.AppendText("This launcher is compatible with any AvP2 installation." + Environment.NewLine);
            textBox1.AppendText(" " + Environment.NewLine);
            textBox1.AppendText("CREDITS: " + Environment.NewLine);
            textBox1.AppendText("-----------------" + Environment.NewLine);
        }

///----------------------------------------------------------------------
///                               BUTTONS
///-----------------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f2 = new Main();
            f2.ShowDialog();
            return;
        }

        private void ButtonHover(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string mediafile = Path.Combine(rootLocation, "..\\LAUNCHRES\\BHOVER.WAV");

            SoundPlayer my_wave_file = new SoundPlayer(mediafile);
            my_wave_file.Play();
        }

        private void ButtonDown(object sender, MouseEventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string mediafile = Path.Combine(rootLocation, "..\\LAUNCHRES\\BSELECT.WAV");

            SoundPlayer my_wave_file = new SoundPlayer(mediafile);
            my_wave_file.Play();
        }

        private void ExitButtonEnter(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.BUTTONEXITUP;
        }

        private void ExitButtonLeave(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.BUTTONEXIT;
        }
    }
}
