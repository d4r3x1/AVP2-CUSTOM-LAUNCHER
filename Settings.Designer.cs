namespace LAUNCHER
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ExitButton = new System.Windows.Forms.Button();
            this.AvP2CmdLine = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBoxWindowMode = new System.Windows.Forms.CheckBox();
            this.checkBoxLaunchUpdates = new System.Windows.Forms.CheckBox();
            this.checkBoxMSPUpdates = new System.Windows.Forms.CheckBox();
            this.checkBoxHardwCurs = new System.Windows.Forms.CheckBox();
            this.checkBoxJoySticks = new System.Windows.Forms.CheckBox();
            this.checkBoxTripleBuff = new System.Windows.Forms.CheckBox();
            this.checkBoxLogos = new System.Windows.Forms.CheckBox();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONEXIT;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitButton.Location = new System.Drawing.Point(419, 201);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 31);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDown);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButtonEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButtonLeave);
            this.ExitButton.MouseHover += new System.EventHandler(this.ButtonHover);
            // 
            // AvP2CmdLine
            // 
            this.AvP2CmdLine.BackColor = System.Drawing.SystemColors.MenuText;
            this.AvP2CmdLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvP2CmdLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvP2CmdLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AvP2CmdLine.Location = new System.Drawing.Point(12, 208);
            this.AvP2CmdLine.MaxLength = 256;
            this.AvP2CmdLine.Name = "AvP2CmdLine";
            this.AvP2CmdLine.Size = new System.Drawing.Size(390, 20);
            this.AvP2CmdLine.TabIndex = 7;
            this.AvP2CmdLine.TextChanged += new System.EventHandler(this.AvP2CmdLine_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LAUNCHER.Properties.Resources.SETTINGBAR;
            this.pictureBox1.Location = new System.Drawing.Point(186, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 30);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 176);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 14);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // checkBoxWindowMode
            // 
            this.checkBoxWindowMode.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxWindowMode.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONWINDOW;
            this.checkBoxWindowMode.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxwindowed;
            this.checkBoxWindowMode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxwindowed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxWindowMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxWindowMode.Location = new System.Drawing.Point(306, 67);
            this.checkBoxWindowMode.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxWindowMode.Name = "checkBoxWindowMode";
            this.checkBoxWindowMode.Size = new System.Drawing.Size(110, 20);
            this.checkBoxWindowMode.TabIndex = 15;
            this.checkBoxWindowMode.UseVisualStyleBackColor = false;
            this.checkBoxWindowMode.CheckedChanged += new System.EventHandler(this.checkBoxWindowMode_CheckedChanged);
            // 
            // checkBoxLaunchUpdates
            // 
            this.checkBoxLaunchUpdates.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLaunchUpdates.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONCHECKUPLAUNCH;
            this.checkBoxLaunchUpdates.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxLupdates;
            this.checkBoxLaunchUpdates.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxLupdates", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLaunchUpdates.ForeColor = System.Drawing.Color.White;
            this.checkBoxLaunchUpdates.Location = new System.Drawing.Point(306, 116);
            this.checkBoxLaunchUpdates.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxLaunchUpdates.Name = "checkBoxLaunchUpdates";
            this.checkBoxLaunchUpdates.Size = new System.Drawing.Size(193, 22);
            this.checkBoxLaunchUpdates.TabIndex = 14;
            this.checkBoxLaunchUpdates.UseVisualStyleBackColor = false;
            this.checkBoxLaunchUpdates.CheckedChanged += new System.EventHandler(this.checkBoxLaunchUpdates_CheckedChanged);
            // 
            // checkBoxMSPUpdates
            // 
            this.checkBoxMSPUpdates.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMSPUpdates.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONCHECKUP;
            this.checkBoxMSPUpdates.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxupdates;
            this.checkBoxMSPUpdates.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxupdates", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxMSPUpdates.ForeColor = System.Drawing.Color.White;
            this.checkBoxMSPUpdates.Location = new System.Drawing.Point(306, 90);
            this.checkBoxMSPUpdates.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxMSPUpdates.Name = "checkBoxMSPUpdates";
            this.checkBoxMSPUpdates.Size = new System.Drawing.Size(152, 23);
            this.checkBoxMSPUpdates.TabIndex = 9;
            this.checkBoxMSPUpdates.UseVisualStyleBackColor = false;
            this.checkBoxMSPUpdates.CheckedChanged += new System.EventHandler(this.checkBoxMSPUpdates_CheckedChanged);
            // 
            // checkBoxHardwCurs
            // 
            this.checkBoxHardwCurs.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxHardwCurs.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONHDWCURS;
            this.checkBoxHardwCurs.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxhardwcurs;
            this.checkBoxHardwCurs.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxhardwcurs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxHardwCurs.ForeColor = System.Drawing.Color.White;
            this.checkBoxHardwCurs.Location = new System.Drawing.Point(122, 117);
            this.checkBoxHardwCurs.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxHardwCurs.Name = "checkBoxHardwCurs";
            this.checkBoxHardwCurs.Size = new System.Drawing.Size(180, 20);
            this.checkBoxHardwCurs.TabIndex = 6;
            this.checkBoxHardwCurs.UseVisualStyleBackColor = false;
            this.checkBoxHardwCurs.CheckedChanged += new System.EventHandler(this.checkBoxHardwCurs_CheckedChanged);
            // 
            // checkBoxJoySticks
            // 
            this.checkBoxJoySticks.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxJoySticks.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONJOYSTICKS;
            this.checkBoxJoySticks.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxjoystick;
            this.checkBoxJoySticks.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxjoystick", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxJoySticks.ForeColor = System.Drawing.Color.White;
            this.checkBoxJoySticks.Location = new System.Drawing.Point(122, 67);
            this.checkBoxJoySticks.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxJoySticks.Name = "checkBoxJoySticks";
            this.checkBoxJoySticks.Size = new System.Drawing.Size(135, 20);
            this.checkBoxJoySticks.TabIndex = 5;
            this.checkBoxJoySticks.UseVisualStyleBackColor = false;
            this.checkBoxJoySticks.CheckedChanged += new System.EventHandler(this.checkBoxJoySticks_CheckedChanged);
            // 
            // checkBoxTripleBuff
            // 
            this.checkBoxTripleBuff.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTripleBuff.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONTRIPBUFF;
            this.checkBoxTripleBuff.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxtriplebuff;
            this.checkBoxTripleBuff.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxtriplebuff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxTripleBuff.ForeColor = System.Drawing.Color.White;
            this.checkBoxTripleBuff.Location = new System.Drawing.Point(122, 91);
            this.checkBoxTripleBuff.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTripleBuff.Name = "checkBoxTripleBuff";
            this.checkBoxTripleBuff.Size = new System.Drawing.Size(178, 20);
            this.checkBoxTripleBuff.TabIndex = 4;
            this.checkBoxTripleBuff.UseVisualStyleBackColor = false;
            this.checkBoxTripleBuff.CheckedChanged += new System.EventHandler(this.checkBoxTripleBuff_CheckedChanged);
            // 
            // checkBoxLogos
            // 
            this.checkBoxLogos.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLogos.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONLOGOS;
            this.checkBoxLogos.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxlogos;
            this.checkBoxLogos.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxlogos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLogos.ForeColor = System.Drawing.Color.White;
            this.checkBoxLogos.Location = new System.Drawing.Point(10, 117);
            this.checkBoxLogos.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxLogos.Name = "checkBoxLogos";
            this.checkBoxLogos.Size = new System.Drawing.Size(106, 20);
            this.checkBoxLogos.TabIndex = 3;
            this.checkBoxLogos.UseVisualStyleBackColor = false;
            this.checkBoxLogos.CheckedChanged += new System.EventHandler(this.checkBoxLogos_CheckedChanged);
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMusic.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONMUSIC;
            this.checkBoxMusic.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxmusic;
            this.checkBoxMusic.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxmusic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxMusic.ForeColor = System.Drawing.Color.White;
            this.checkBoxMusic.Location = new System.Drawing.Point(10, 91);
            this.checkBoxMusic.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(106, 20);
            this.checkBoxMusic.TabIndex = 2;
            this.checkBoxMusic.UseVisualStyleBackColor = false;
            this.checkBoxMusic.CheckedChanged += new System.EventHandler(this.checkBoxMusic_CheckedChanged);
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSound.BackgroundImage = global::LAUNCHER.Properties.Resources.BUTTONSOUND;
            this.checkBoxSound.Checked = global::LAUNCHER.Properties.Settings.Default.checkboxsound;
            this.checkBoxSound.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LAUNCHER.Properties.Settings.Default, "checkboxsound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxSound.ForeColor = System.Drawing.Color.White;
            this.checkBoxSound.Location = new System.Drawing.Point(10, 65);
            this.checkBoxSound.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(106, 22);
            this.checkBoxSound.TabIndex = 1;
            this.checkBoxSound.Text = "                         ";
            this.checkBoxSound.UseVisualStyleBackColor = false;
            this.checkBoxSound.CheckedChanged += new System.EventHandler(this.checkBoxSound_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::LAUNCHER.Properties.Resources.MAINBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 252);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxWindowMode);
            this.Controls.Add(this.checkBoxLaunchUpdates);
            this.Controls.Add(this.checkBoxMSPUpdates);
            this.Controls.Add(this.AvP2CmdLine);
            this.Controls.Add(this.checkBoxHardwCurs);
            this.Controls.Add(this.checkBoxJoySticks);
            this.Controls.Add(this.checkBoxTripleBuff);
            this.Controls.Add(this.checkBoxLogos);
            this.Controls.Add(this.checkBoxMusic);
            this.Controls.Add(this.checkBoxSound);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVP2 SETTINGS";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.CheckBox checkBoxLogos;
        private System.Windows.Forms.CheckBox checkBoxTripleBuff;
        private System.Windows.Forms.CheckBox checkBoxJoySticks;
        private System.Windows.Forms.CheckBox checkBoxHardwCurs;
        private System.Windows.Forms.TextBox AvP2CmdLine;
        private System.Windows.Forms.CheckBox checkBoxMSPUpdates;
        private System.Windows.Forms.CheckBox checkBoxLaunchUpdates;
        private System.Windows.Forms.CheckBox checkBoxWindowMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}