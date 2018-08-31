using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Net;

namespace LAUNCHER
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");

            if (File.Exists(cmdfileV))
            {
                AvP2CmdLine.Text = File.ReadAllText(cmdfileV).Remove(0, 293);
            }
        }

///----------------------------------------------------------------------
///                               BUTTONS
///-----------------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");

            string current = File.ReadAllText(cmdfileV);
            if (current.Length > 293)
            {
                File.WriteAllText(cmdfileV, current.Remove(293));
            }
                File.AppendAllText(cmdfileV, AvP2CmdLine.Text);

                Properties.Settings.Default.Save();

                this.Hide();
                Main f2 = new Main();
                f2.ShowDialog();
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

///----------------------------------------------------------------------
///                               CHECKBOXES
///-----------------------------------------------------------------------
    
        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string soundon = "+DisableSound 0";
            string soundoff = "+DisableSound 1";

            if (checkBoxSound.Checked == true)
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(soundon, soundoff));
                streamWriter.Close();
            }
            else
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(soundoff, soundon));
                streamWriter.Close();
            }
        }

        private void checkBoxMusic_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string musicon = "+DisableMusic 0";
            string musicoff = "+DisableMusic 1";

            if (checkBoxMusic.Checked == true)
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(musicon, musicoff));
                streamWriter.Close();
            }
            else
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(musicoff, musicon));
                streamWriter.Close();
            }
        }

        private void checkBoxLogos_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string logoson = "+DisableMovies 0";
            string logosoff = "+DisableMovies 1";

            if (checkBoxLogos.Checked == true)
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(logoson, logosoff));
                streamWriter.Close();
            }
            else
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(logosoff, logoson));
                streamWriter.Close();
            }
        }

        private void checkBoxTripleBuff_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string tripbuffson = "+EnableTripBuf 1";
            string tripbuffoff = "+EnableTripBuf 0";

            if (checkBoxTripleBuff.Checked == true)
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(tripbuffson, tripbuffoff));
                streamWriter.Close();
            }
            else
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(tripbuffoff, tripbuffson));
                streamWriter.Close();
            }
        }

        private void checkBoxJoySticks_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string joysticksson = "+EnableJoysticks 1";
            string joysticksoff = "+EnableJoysticks 0";

            if (checkBoxJoySticks.Checked == true)
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(joysticksson, joysticksoff));
                streamWriter.Close();
            }
            else
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(joysticksoff, joysticksson));
                streamWriter.Close();
            }
        }

        private void checkBoxHardwCurs_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string hardwcurson = "+DisableHardwareCursor 0";
            string hardwcursoff = "+DisableHardwareCursor 1";

            if (checkBoxTripleBuff.Checked == true)
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(hardwcurson, hardwcursoff));
                streamWriter.Close();
            }
            else
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cmdfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cmdfileV);
                streamWriter.Write(contents.Replace(hardwcursoff, hardwcurson));
                streamWriter.Close();
            }
        }

        private void checkBoxMSPUpdates_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string MSP = Path.Combine(rootLocation, "..");

            if (!checkBoxMSPUpdates.Checked == false)
            {
                MessageBox.Show("Coming Soon!!!");
            }

            //          if (!Directory.Exists(AVP2O))
            //              Directory.CreateDirectory(AVP2O);

            //          if (checkBoxMSPUpdates.Checked == true);
            //          { 
            //              var files = new DirectoryInfo("..").GetFiles("*.DLL");
            //              foreach (var file in files)
            //          {

            //          if (DateTime.UtcNow - file.CreationTimeUtc > TimeSpan.FromDays(30))
            //          {
            //               MessageBox.Show("AVP2 Online is outdated!!! Klick 'OK' to download the latest version!!!");
            //               WebClient client = new WebClient();
            //               Uri ur = new Uri("http://www.avpunknown.com/something.dll" + "http://www.avpunknown.com/something2.dll");
            //               client.DownloadProgressChanged += WebClientDownloadProgressChanged;
            //               client.DownloadDataCompleted += WebClientDownloadCompleted;
            //               client.DownloadFileAsync(ur, "..");
            //           }

            //          if (checkBoxAVP2OUpdates.Checked == false)
            //           {
            //               MessageBox.Show("AVP2O Automatic updates turned off!!!");
            //           }
            //    
            //           }
        }

        private void checkBoxLaunchUpdates_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string launcher = Path.Combine(rootLocation, "..\\AvP2Launcher.exe");

            if (!checkBoxLaunchUpdates.Checked == false)
            {
                MessageBox.Show("Coming Soon!!!");
            }
//          if (checkBoxLaunchUpdates.Checked == true)
//          {
//              File.Exists(launcher);

//              var files = new DirectoryInfo(launcher).GetFiles("AVP2SA.EXE");
//              foreach (var file in files)
//          {

//          if (DateTime.UtcNow - file.CreationTimeUtc > TimeSpan.FromDays(30))
//          {
//              MessageBox.Show("The launcher is outdated!!! Klick 'OK' to download the latest version!!!");
//              WebClient client = new WebClient();
//              Uri ur = new Uri("http://www.avpunknown.com/AVP2SA.EXE");
//              client.DownloadProgressChanged += WebClientDownloadProgressChanged;
//              client.DownloadDataCompleted += WebClientDownloadCompleted;
//              client.DownloadFileAsync(ur, launcher);
//           }

//           if (checkBoxLaunchUpdates.Checked == false)
//               {
//                MessageBox.Show("Launcher Automatic updates turned off!!!");
//               }
//    
        }

        private void checkBoxWindowMode_CheckedChanged(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string cfgfileV = Path.Combine(rootLocation, "..\\autoexec.cfg");
            string windowsoff = "\"Windowed\"" + " " + "\"0\"";
            string windowson = "\"Windowed\"" + " " + "\"1\"";

            if (checkBoxWindowMode.Checked == true)
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cfgfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cfgfileV);
                streamWriter.Write(contents.Replace(windowsoff, windowson));
                streamWriter.Close();
            }
            else
            {
                StreamReader streamReader;
                streamReader = File.OpenText(cfgfileV);
                string contents = streamReader.ReadToEnd();
                streamReader.Close();
                StreamWriter streamWriter = File.CreateText(cfgfileV);
                streamWriter.Write(contents.Replace(windowson, windowsoff));
            }
        }

///----------------------------------------------------------------------
///                               TEXTBOXES
///-----------------------------------------------------------------------

        private void AvP2CmdLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void AvP2PHCmdLineTextChanged(object sender, EventArgs e)
        {

        }

///----------------------------------------------------------------------
///                            FUNCTIONS
///-----------------------------------------------------------------------

        void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("Download status: {0}%.", e.ProgressPercentage);
        }

        void WebClientDownloadCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            Console.WriteLine("Download finished!");
        }
    }
}
