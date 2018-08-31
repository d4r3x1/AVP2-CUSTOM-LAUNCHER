using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace LAUNCHER
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            startupsound();
        }

///----------------------------------------------------------------------
///                       BUTTONS - FUNCTIONALITY
///-----------------------------------------------------------------------

        ///This button starts the game itself.

        private void PlayAvP2Button_Click(object sender, EventArgs e)
        {

            string rootLocation = typeof(Program).Assembly.Location;

            string lithprocV = Path.Combine(rootLocation, "..\\lithtech.exe");
            string cfgfileV = Path.Combine(rootLocation, "..\\autoexec.cfg");
            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string lithargV = "-cmdfile avp2cmds.txt";

            if (!File.Exists(cmdfileV))
            {
                Prerequisites();
            }
            if (File.Exists(cfgfileV))
            {
                Directory.SetCurrentDirectory(Path.Combine(rootLocation, ".."));
                Process.Start(lithprocV, lithargV);
            }
            else  
            {
                Prerequisites();
                Directory.SetCurrentDirectory(Path.Combine(rootLocation, ".."));
                Process.Start(lithprocV, lithargV);
            }
        }

        ///This button starts the our multiplayer experience.

        private void StartMPButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multiplayer f2 = new Multiplayer();
            f2.ShowDialog();
            return;
        }

        ///This button opens the settings form.
        ///It also checks if the required files exist or not.

        private void AvP2SettingsButton_Click(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;

            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string cfgfileV = Path.Combine(rootLocation, "..\\autoexec.cfg");

            if (!File.Exists(cmdfileV))
            {
                Prerequisites();
            }
            if (!File.Exists(cfgfileV))
            {
                Prerequisites();
            }
            else
            {
                Prerequisites();
                this.Hide();
                Settings f2 = new Settings();
                f2.ShowDialog();
            }
        }

        ///This button opens the README form.

        private void ReadmeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Readme f2 = new Readme();
            f2.ShowDialog();
            return;
        }

        ///This button does something rather funky.

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

///----------------------------------------------------------------------
///                          BUTTONS - EFFECTS
///-----------------------------------------------------------------------

        ///Plays a sound whenever we hover over a button.

        private void ButtonHover(object sender, EventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string mediafile = Path.Combine(rootLocation, "..\\LAUNCHRES\\BHOVER.WAV");

            SoundPlayer my_wave_file = new SoundPlayer(mediafile);
            my_wave_file.Play();
        }

        ///Plays a sound whenever we press a button.

        private void ButtonDown(object sender, MouseEventArgs e)
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string mediafile = Path.Combine(rootLocation, "..\\LAUNCHRES\\BSELECT.WAV");

            SoundPlayer my_wave_file = new SoundPlayer(mediafile);
            my_wave_file.Play();
        }

        ///Highlights the button on hover.

        private void PlayAvP2ButtonEnter(object sender, EventArgs e)
        {
            PlayAvP2Button.BackgroundImage = Properties.Resources.BUTTONPLAYUP;
        }

        ///Returns the button back to normal whenever we leave it.

        private void PlayAvP2ButtonLeave(object sender, EventArgs e)
        {
            PlayAvP2Button.BackgroundImage = Properties.Resources.BUTTONPLAY;
        }

        ///Highlights the button on hover.

        private void StartMPButtonEnter(object sender, EventArgs e)
        {
            StartMPButton.BackgroundImage = Properties.Resources.BUTTONSTARTMPUP;
        }

        ///Returns the button back to normal whenever we leave it.

        private void StartMPButtonLeave(object sender, EventArgs e)
        {
            StartMPButton.BackgroundImage = Properties.Resources.BUTTONSTARTMP;
        }

        ///Highlights the button on hover.

        private void AvP2SettingsButtonEnter(object sender, EventArgs e)
        {
            AvP2SettingsButton.BackgroundImage = Properties.Resources.BUTTONSETTINGSUP;
        }

        ///Returns the button back to normal whenever we leave it.

        private void AvP2SettingsButtonLeave(object sender, EventArgs e)
        {
            AvP2SettingsButton.BackgroundImage = Properties.Resources.BUTTONSETTINGS;
        }

        ///Highlights the button on hover.

        private void ReadmeButtonEnter(object sender, EventArgs e)
        {
            ReadmeButton.BackgroundImage = Properties.Resources.BUTTONSREADMEUP;
        }

        ///Returns the button back to normal whenever we leave it.

        private void ReadmeButtonLeave(object sender, EventArgs e)
        {
            ReadmeButton.BackgroundImage = Properties.Resources.BUTTONSREADME;
        }

        ///Highlights the button on hover.

        private void ExitButtonEnter(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.BUTTONEXITUP;
        }

        ///Returns the button back to normal whenever we leave it.

        private void ExitButtonLeave(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.BUTTONEXIT;
        }

///----------------------------------------------------------------------
///                           PREREQUISITES
///-----------------------------------------------------------------------

        private void Prerequisites()
        {

            string rootLocation = typeof(Program).Assembly.Location;

            string cfgfileV = Path.Combine(rootLocation, "..\\autoexec.cfg");
            string cfgcmdsV =
                                    "\"FARZ\"" + " " + "\"100000.000000\""
            + Environment.NewLine + "\"NUMCONSOLELINES\"" + " " + "\"0\""
            + Environment.NewLine + "\"LMFullBright\"" + " " + "\"0\""
            + Environment.NewLine + "\"JoinPopFilter\"" + " " + "\"0\""
            + Environment.NewLine + "\"SpeciesName\"" + " " + "\"Marine\""
            + Environment.NewLine + "\"JoinTypeFilter\"" + " " + "\"0\""
            + Environment.NewLine + "\"VS_SPRITES_NOZ\"" + " " + "\"128\""
            + Environment.NewLine + "\"CARDDESC\"" + " " + "\"display\""
            + Environment.NewLine + "\"NormalTurnRate\"" + " " + "\"1.500000\""
            + Environment.NewLine + "\"MouseInvertYAxis\"" + " " + "\"0\""
            + Environment.NewLine + "\"MODELWARBLE\"" + " " + "\"0\""
            + Environment.NewLine + "\"DETAILTEXTURESCALE\"" + " " + "\"1.0\""
            + Environment.NewLine + "\"AutoswitchWeapons\"" + " " + "\"1\""
            + Environment.NewLine + "\"MaxModelShadows\"" + " " + "\"1\""
            + Environment.NewLine + "\"LIGHTMODELSPRITES\"" + " " + "\"1\""
            + Environment.NewLine + "\"DynamicLightSetting\"" + " " + "\"2.000000\""
            + Environment.NewLine + "\"VS_PARTICLESYSTEMS\"" + " " + "\"128\""
            + Environment.NewLine + "\"FOGENABLE\"" + " " + "\"0\""
            + Environment.NewLine + "\"ScreenFlash\"" + " " + "\"1.000000\""
            + Environment.NewLine + "\"HeadCanting\"" + " " + "\"1\""
            + Environment.NewLine + "\"ENVPANSPEED\"" + " " + "\"0.000500\""
            + Environment.NewLine + "\"MODELLOD\"" + " " + "\"2.000000\""
            + Environment.NewLine + "\"LowViolence\"" + " " + "\"0\""
            + Environment.NewLine + "\"OPTIMIZESURFACES\"" + " " + "\"1.0\""
            + Environment.NewLine + "\"RunLock\"" + " " + "\"1\""
            + Environment.NewLine + "\"WeaponSway\"" + " " + "\"1\""
            + Environment.NewLine + "\"VS_SPRITES\"" + " " + "\"512\""
            + Environment.NewLine + "\"OrientOverlay\"" + " " + "\"1\""
            + Environment.NewLine + "\"ModelShadowProj\"" + " " + "\"1\""
            + Environment.NewLine + "\"ScalingMenus\"" + " " + "\"1\""
            + Environment.NewLine + "\"LIGHTMAP\"" + " " + "\"1\""
            + Environment.NewLine + "\"DetailLevel\"" + " " + "\"3\""
            + Environment.NewLine + "\"JoinDedicatedFilter\"" + " " + "\"0\""
            + Environment.NewLine + "\"VS_POLYGRIDS_TRANSLUCENT\"" + " " + "\"32\""
            + Environment.NewLine + "\"MouseSensitivity\"" + " " + "\"7.000000\""
            + Environment.NewLine + "\"SATURATE\"" + " " + "\"1\""
            + Environment.NewLine + "\"Sound16Bit\"" + " " + "\"1\""
            + Environment.NewLine + "\"FastTurnRate\"" + " " + "\"2.300000\""
            + Environment.NewLine + "\"BITDEPTH\"" + " " + "\"32\""
            + Environment.NewLine + "\"ClipSpeed\"" + " " + "\"1000.0\""
            + Environment.NewLine + "\"VS_MODELS_CHROMAKEY\"" + " " + "\"512\""
            + Environment.NewLine + "\"VS_POLYGRIDS\"" + " " + "\"32\""
            + Environment.NewLine + "\"ModelShadowProjLOD\"" + " " + "\"1\""
            + Environment.NewLine + "\"FixTJunc\"" + " " + "\"1\""
            + Environment.NewLine + "\"SCREENWIDTH\"" + " " + "\"800\""
            + Environment.NewLine + "\"Trilinear\"" + " " + "\"1\""
            + Environment.NewLine + "\"RENDERDLL\"" + " " + "\"d3d.ren\""
            + Environment.NewLine + "\"MASTERPALETTEMODE\"" + " " + "\"1.000000\""
            + Environment.NewLine + "\"MaxWorldPoliesToDraw\"" + " " + "\"90000\""
            + Environment.NewLine + "\"SpecialFX\"" + " " + "\"2.000000\""
            + Environment.NewLine + "\"RATEENABLE\"" + " " + "\"2\""
            + Environment.NewLine + "\"VS_WORLDMODELS_CHROMAKEY\"" + " " + "\"256\""
            + Environment.NewLine + "\"modeldist1\"" + " " + "\"150.000000\""
            + Environment.NewLine + "\"UpdateRateInitted\"" + " " + "\"1\""
            + Environment.NewLine + "\"32BitTextures\"" + " " + "\"1\""
            + Environment.NewLine + "\"GAMMA\"" + " " + "\"1.000000\""
            + Environment.NewLine + "\"AspectRatio\"" + " " + "\"2\""
            + Environment.NewLine + "\"BulletHoles\"" + " " + "\"100.000000\""
            + Environment.NewLine + "\"modeldist2\"" + " " + "\"250.000000\""
            + Environment.NewLine + "\"ObjectiveMessages\"" + " " + "\"1\""
            + Environment.NewLine + "\"MuzzleLight\"" + " " + "\"1\""
            + Environment.NewLine + "\"EnableHints\"" + " " + "\"1\""
            + Environment.NewLine + "\"NumRuns\"" + " " + "\"1.000000\""
            + Environment.NewLine + "\"DRAWSKY\"" + " " + "\"1\""
            + Environment.NewLine + "\"MsgMgrTimeScale\"" + " " + "\"1.000000\""
            + Environment.NewLine + "\"VS_CANVASES\"" + " " + "\"32\""
            + Environment.NewLine + "\"modeldist3\"" + " " + "\"350.000000\""
            + Environment.NewLine + "\"DetailTextures\"" + " " + "\"1\""
            + Environment.NewLine + "\"enabledevice\"" + " " + "\"##mouse\""
            + Environment.NewLine + "\"UseJoystick\"" + " " + "\"0\""
            + Environment.NewLine + "\"VS_CANVASES_TRANSLUCENT\"" + " " + "\"128\""
            + Environment.NewLine + "\"MultipassGouraud\"" + " " + "\"1\""
            + Environment.NewLine + "\"IgnoreTaunts\"" + " " + "\"0\""
            + Environment.NewLine + "\"PickupIconDuration\"" + " " + "\"5.000000\""
            + Environment.NewLine + "\"EnvMapEnable\"" + " " + "\"1\""
            + Environment.NewLine + "\"EnvMapWorld\"" + " " + "\"1\""
            + Environment.NewLine + "\"InputRate\"" + " " + "\"12.000000\""
            + Environment.NewLine + "\"MusicVolume\"" + " " + "\"60.000000\""
            + Environment.NewLine + "\"maxswvoices\"" + " " + "\"64.000000\""
            + Environment.NewLine + "\"VS_LINESYSTEMS\"" + " " + "\"128\""
            + Environment.NewLine + "\"multiplayer\"" + " " + "\"0\""
            + Environment.NewLine + "\"FORCECLEAR\"" + " " + "\"1\""
            + Environment.NewLine + "\"FASTLIGHT\"" + " " + "\"0\""
            + Environment.NewLine + "\"SoundVolume\"" + " " + "\"100.000000\""
            + Environment.NewLine + "\"JoinSort\"" + " " + "\"68\""
            + Environment.NewLine + "\"INPUTRATE\"" + " " + "\"57.000000\""
            + Environment.NewLine + "\"POLYGRIDS\"" + " " + "\"1.000000\""
            + Environment.NewLine + "\"VS_MODELS\"" + " " + "\"256\""
            + Environment.NewLine + "\"GroupOffset0\"" + " " + "\"0\""
            + Environment.NewLine + "\"MouseLook\"" + " " + "\"1\""
            + Environment.NewLine + "\"Subtitles\"" + " " + "\"1\""
            + Environment.NewLine + "\"GroupOffset1\"" + " " + "\"0\""
            + Environment.NewLine + "\"EnableSky\"" + " " + "\"1\""
            + Environment.NewLine + "\"globaldetail\"" + " " + "\"2.000000\""
            + Environment.NewLine + "\"GroupOffset2\"" + " " + "\"-1\""
            + Environment.NewLine + "\"NEARZ\"" + " " + "\"4.000000\""
            + Environment.NewLine + "\"SFXVolume\"" + " " + "\"90.000000\""
            + Environment.NewLine + "\"InvertHack\"" + " " + "\"0\""
            + Environment.NewLine + "\"musictype\"" + " " + "\"ima\""
            + Environment.NewLine + "\"GroupOffset3\"" + " " + "\"0\""
            + Environment.NewLine + "\"GroupOffset4\"" + " " + "\"0\""
            + Environment.NewLine + "\"MouseInvertY\"" + " " + "\"0\""
            + Environment.NewLine + "\"GroupOffsetY\"" + " " + "\"0\""
            + Environment.NewLine + "\"GroupOffset5\"" + " " + "\"0\""
            + Environment.NewLine + "\"VS_LIGHTS\"" + " " + "\"64\""
            + Environment.NewLine + "\"UpdateRate\"" + " " + "\"100\""
            + Environment.NewLine + "\"ModelShadowProjRes\"" + " " + "\"512\""
            + Environment.NewLine + "\"GroupOffset6\"" + " " + "\"-1\""
            + Environment.NewLine + "\"CrouchLock\"" + " " + "\"0\""
            + Environment.NewLine + "\"GroupOffset7\"" + " " + "\"-1\""
            + Environment.NewLine + "\"MODELFULLBRITE\"" + " " + "\"1\""
            + Environment.NewLine + "\"GroupOffset8\"" + " " + "\"-1\""
            + Environment.NewLine + "\"DEBUGLEVEL\"" + " " + "\"0\""
            + Environment.NewLine + "\"GroupOffset9\"" + " " + "\"-1\""
            + Environment.NewLine + "\"CLOUDMAPLIGHT\"" + " " + "\"1.000000\""
            + Environment.NewLine + "\"GameScreenHeight\"" + " " + "\"600\""
            + Environment.NewLine + "\"MsgMgrMaxHeight\"" + " " + "\"0.200000\""
            + Environment.NewLine + "\"DrawViewModel\"" + " " + "\"1\""
            + Environment.NewLine + "\"SCREENHEIGHT\"" + " " + "\"600\""
            + Environment.NewLine + "\"VS_MODELS_TRANSLUCENT\"" + " " + "\"512\""
            + Environment.NewLine + "\"TripleBuffer\"" + " " + "\"1\""
            + Environment.NewLine + "\"ServerConfig\"" + " " + "\"unnamed\""
            + Environment.NewLine + "\"MUSICENABLE\"" + " " + "\"1\""
            + Environment.NewLine + "\"JoinPingFilter\"" + " " + "\"0\""
            + Environment.NewLine + "\"32BitLightMaps\"" + " " + "\"1\""
            + Environment.NewLine + "\"WallWalkLock\"" + " " + "\"0\""
            + Environment.NewLine + "\"DYNAMICLIGHT\"" + " " + "\"1\""
            + Environment.NewLine + "\"GameScreenWidth\"" + " " + "\"800\""
            + Environment.NewLine + "\"ImpactFXLevel\"" + " " + "\"2\""
            + Environment.NewLine + "\"PerformanceConfig\"" + " " + "\".DefaultLow\""
            + Environment.NewLine + "\"SOUNDENABLE\"" + " " + "\"1\""
            + Environment.NewLine + "\"FogPerformanceScale\"" + " " + "\"100\""
            + Environment.NewLine + "\"WARBLESCALE\"" + " " + "\"95\""
            + Environment.NewLine + "\"LookUpRate\"" + " " + "\"5.000000\""
            + Environment.NewLine + "\"GameBitDepth\"" + " " + "\"32\""
            + Environment.NewLine + "\"Gore\"" + " " + "\"1.000000\""
            + Environment.NewLine + "\"HeadBob\"" + " " + "\"1\""
            + Environment.NewLine + "\"DebrisFXLevel\"" + " " + "\"2\""
            + Environment.NewLine + "\"VS_WORLDMODELS\"" + " " + "\"256\""
            + Environment.NewLine + "\"ShellCasings\"" + " " + "\"1\""
            + Environment.NewLine + "\"LookSpring\"" + " " + "\"0.000000\""
            + Environment.NewLine + "\"MIPMAPDIST\"" + " " + "\"375.000000\""
            + Environment.NewLine + "\"SHADOWZRANGE\"" + " " + "\"17.000000\""
            + Environment.NewLine + "\"JoinVersionFilter\"" + " " + "\"0\""
            + Environment.NewLine + "\"SHADOWLODOFFSET\"" + " " + "\"100.000000\""
            + Environment.NewLine + "\"LIGHTSATURATE\"" + " " + "\"1.0\""
            + Environment.NewLine + "\"Windowed\"" + " " + "\"0\""
            + Environment.NewLine + "\"ProfileName\"" + " " + "\"Player_0\""
            + Environment.NewLine + "\"WARBLESPEED\"" + " " + "\"15\""
            + Environment.NewLine + "\"Windowed\"" + " " + "\"0\""
            + Environment.NewLine + "AddAction" + " " + "Forward" + " " + "0"
            + Environment.NewLine + "AddAction" + " " + "Backward" + " " + "1"
            + Environment.NewLine + "AddAction" + " " + "Left" + " " + "2"
            + Environment.NewLine + "AddAction" + " " + "Right" + " " + "3"
            + Environment.NewLine + "AddAction" + " " + "Strafe" + "  " + "4"
            + Environment.NewLine + "AddAction" + " " + "StrafeLeft" + "  " + "5"
            + Environment.NewLine + "AddAction" + " " + "StrafeRight" + "  " + "6"
            + Environment.NewLine + "AddAction" + " " + "Run" + " " + "7"
            + Environment.NewLine + "AddAction" + " " + "Duck" + " " + "8"
            + Environment.NewLine + "AddAction" + " " + "Jump" + " " + "9"
            + Environment.NewLine + "AddAction" + " " + "LookUp" + " " + "10"
            + Environment.NewLine + "AddAction" + " " + "LookDown" + " " + "11"
            + Environment.NewLine + "AddAction" + " " + "CenterView" + " " + "12"
            + Environment.NewLine + "AddAction" + " " + "RunLock" + " " + "13"
            + Environment.NewLine + "AddAction" + " " + "Fire" + " " + "14"
            + Environment.NewLine + "AddAction" + " " + "AltFire" + " " + "15"
            + Environment.NewLine + "AddAction" + " " + "Reload" + " " + "16"
            + Environment.NewLine + "AddAction" + " " + "Activate" + " " + "17"
            + Environment.NewLine + "AddAction" + " " + "PrevWeapon" + " " + "18"
            + Environment.NewLine + "AddAction" + " " + "NextWeapon" + " " + "19"
            + Environment.NewLine + "AddAction" + " " + "ZoomIn" + " " + "20"
            + Environment.NewLine + "AddAction" + " " + "ZoomOut" + " " + "21"
            + Environment.NewLine + "AddAction" + " " + "LastWeapon" + " " + "22"
            + Environment.NewLine + "AddAction" + " " + "CrouchToggle" + " " + "23"
            + Environment.NewLine + "AddAction" + " " + "TorchSelect " + " " + "24"
            + Environment.NewLine + "AddAction" + " " + "WallWalk" + " " + "25"
            + Environment.NewLine + "AddAction" + " " + "WallWalkToggle" + " " + "26"
            + Environment.NewLine + "AddAction" + " " + "PounceJump" + " " + "27"
            + Environment.NewLine + "AddAction" + " " + "EnergySift" + " " + "28"
            + Environment.NewLine + "AddAction" + " " + "MediComp" + " " + "29"
            + Environment.NewLine + "AddAction" + " " + "Weapon0" + " " + "30"
            + Environment.NewLine + "AddAction" + " " + "Weapon1" + " " + "31"
            + Environment.NewLine + "AddAction" + " " + "Weapon2" + " " + "32"
            + Environment.NewLine + "AddAction" + " " + "Weapon3" + " " + "33"
            + Environment.NewLine + "AddAction" + " " + "Weapon4" + " " + "34"
            + Environment.NewLine + "AddAction" + " " + "Weapon5" + " " + "35"
            + Environment.NewLine + "AddAction" + " " + "Weapon6" + " " + "36"
            + Environment.NewLine + "AddAction" + " " + "Weapon7" + " " + "37"
            + Environment.NewLine + "AddAction" + " " + "Weapon8" + " " + "38"
            + Environment.NewLine + "AddAction" + " " + "Weapon9" + " " + "39"
            + Environment.NewLine + "AddAction" + " " + "Item0" + " " + "40"
            + Environment.NewLine + "AddAction" + " " + "Item1" + " " + "41"
            + Environment.NewLine + "AddAction" + " " + "Item2" + " " + "42"
            + Environment.NewLine + "AddAction" + " " + "Item3" + " " + "43"
            + Environment.NewLine + "AddAction" + " " + "Item4" + " " + "44"
            + Environment.NewLine + "AddAction" + " " + "Item5" + " " + "45"
            + Environment.NewLine + "AddAction" + " " + "Item6" + " " + "46"
            + Environment.NewLine + "AddAction" + " " + "Item7" + " " + "47"
            + Environment.NewLine + "AddAction" + " " + "Item8" + " " + "48"
            + Environment.NewLine + "AddAction" + " " + "Item9" + " " + "49"
            + Environment.NewLine + "AddAction" + " " + "PrevVision" + " " + "50"
            + Environment.NewLine + "AddAction" + " " + "NextVision" + " " + "51"
            + Environment.NewLine + "AddAction" + " " + "PrevHud" + " " + "60"
            + Environment.NewLine + "AddAction" + " " + "NextHud" + " " + "61"
            + Environment.NewLine + "AddAction" + " " + "MouseAim" + " " + "62"
            + Environment.NewLine + "AddAction" + " " + "Crosshair" + " " + "63"
            + Environment.NewLine + "AddAction" + " " + "ChaseView" + " " + "64"
            + Environment.NewLine + "AddAction" + " " + "QuickSave" + " " + "65"
            + Environment.NewLine + "AddAction" + " " + "QuickLoad" + " " + "66"
            + Environment.NewLine + "AddAction" + " " + "Message" + " " + "70"
            + Environment.NewLine + "AddAction" + " " + "TeamMessage" + " " + "71"
            + Environment.NewLine + "AddAction" + " " + "ScoreDisplay" + " " + "72"
            + Environment.NewLine + "AddAction" + " " + "PlayerInfo" + " " + "73"
            + Environment.NewLine + "AddAction" + " " + "Taunt" + " " + "74"
            + Environment.NewLine + "AddAction" + " " + "LeaveUnassigned" + " " + "99"
            + Environment.NewLine + "AddAction" + " " + "Axis3" + " " + "-3"
            + Environment.NewLine + "AddAction" + " " + "Axis2" + " " + "-2"
            + Environment.NewLine + "AddAction" + " " + "Axis1" + " " + "-1"
            + Environment.NewLine + " "
            + Environment.NewLine + "enabledevice" + " " + "\"##keyboard\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##48\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"PrevVision\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##16\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"MediComp\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##18\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"EnergySift\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##45\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"LastWeapon\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##11\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon9\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##10\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon8\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##9\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon7\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##8\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon6\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##7\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon5\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##6\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon4\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##5\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon3\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##4\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon2\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##3\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon1\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##2\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Weapon0\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"##20\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"TorchSelect\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#35\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Item2\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#33\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Item1\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#34\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Item0\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#209\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"ZoomOut\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#201\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"ZoomIn\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#19\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Reload\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#44\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"PrevWeapon\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#16\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"PrevWeapon\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#53\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"CrouchToggle\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#42\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Duck\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#52\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Crosshair\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#14\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Taunt\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#43\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"TeamMessage\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#28\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Message\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#15\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"ScoreDisplay\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#210\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"MouseAim\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#211\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"CenterView\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#207\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"LookDown\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#199\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"LookUp\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#47\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"NextVision\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#57\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Jump\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#50\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"RunLock\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#37\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Strafe\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#32\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"StrafeRight\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#30\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"StrafeLeft\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#205\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Right\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#203\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Left\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#17\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Forward\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#31\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Backward\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#12\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"PrevHud\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#13\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"NextHud\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#64\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"QuickSave\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"#64\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"QuickLoad\""
            + Environment.NewLine + "rangebind" + " " + "\"##keyboard\"" + " " + "\"y\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"ChaseView\""
            + Environment.NewLine + "enabledevice" + " " + "\"##mouse\""
            + Environment.NewLine + "rangebind" + " " + "\"##mouse\"" + " " + "\"##z-axis\"" + " " + "-255.000000" + " " + "-0.100000" + " " + "ZoomOut" + " " + "0.100000" + " " + "255.000000" + " " + "\"ZoomIn\""
            + Environment.NewLine + "rangebind" + " " + "\"##mouse\"" + " " + "\"##4\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"AltFire\""
            + Environment.NewLine + "rangebind" + " " + "\"##mouse\"" + " " + "\"##3\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Fire\""
            + Environment.NewLine + "rangebind" + " " + "\"##mouse\"" + " " + "\"##y-axis\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Axis2\""
            + Environment.NewLine + "scale" + " " + "\"##mouse\"" + " " + "\"##y-axis\"" + " " + "0.000983"
            + Environment.NewLine + "rangebind" + " " + "\"##mouse\"" + " " + "\"##x-axis\"" + " " + "0.000000" + " " + "0.000000" + " " + "\"Axis1\""
            + Environment.NewLine + "scale" + " " + "\"##mouse\"" + " " + "\"##x-axis\"" + " " + "0.002711"
            + Environment.NewLine + "ModelAdd" + " " + "0.000000" + " " + "0.000000" + " " + "0.000000"
            + Environment.NewLine + "ModelDirAdd" + " " + "0.000000" + " " + "0.000000" + " " + "0.000000"
            + Environment.NewLine + "WMAmbient" + " " + "0.000000" + " " + "0.000000" + " " + "0.000000";

            string cmdfileV = Path.Combine(rootLocation, "..\\avp2cmds.txt");
            string commandsV =
            "-windowtitle AvP2" + " " + "-rez AVP2.rez" + " " + "-rez sounds.rez" + " " + "-rez Alien.rez" + " " + "-rez Marine.rez" + " " + "-rez Predator.rez" + " "
            + "-rez Multi.rez" + " " + "-rez AVP2dll.rez" + " " + "-rez AVP2l.rez" + " " + "-rez custom" + " " + "-rez AVP2p.rez" + " " + "-rez AVP2p2.rez" + " "
            + "-rez AVP2P1.REZ" + " " + "+DisableMusic 0" + " " + "+DisableSound 0" + " " + "+DisableMovies 0" + " " + "+EnableTripBuf 1" + " " + "+DisableHardwareCursor 0";

            if (!File.Exists(cfgfileV))
            {
                File.WriteAllText(cfgfileV, cfgcmdsV);
            }

            if (!File.Exists(cmdfileV))
            {
                File.WriteAllText(cmdfileV, commandsV);
            }
        }

///----------------------------------------------------------------------
///                           STARTUP SOUND
///-----------------------------------------------------------------------

        private void startupsound()
        {
            string rootLocation = typeof(Program).Assembly.Location;
            string mediafile = Path.Combine(rootLocation, "..\\LAUNCHRES\\LAUNCH.WAV");

            SoundPlayer my_wave_file = new SoundPlayer(mediafile);
            my_wave_file.Play();
        }

    }
}
