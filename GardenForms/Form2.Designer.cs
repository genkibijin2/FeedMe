namespace GardenForms
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            poisonStyleManager1 = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            Toolkit = new ReaLTaiizor.Forms.DungeonForm();
            trackBar1 = new TrackBar();
            TemperatureInput = new ReaLTaiizor.Controls.DungeonTextBox();
            ConvertButton = new ReaLTaiizor.Controls.DungeonButtonLeft();
            GardenToolsKill = new ReaLTaiizor.Controls.PoisonButton();
            InputConsole1 = new ReaLTaiizor.Controls.DungeonButtonLeft();
            OutputConsole1 = new ReaLTaiizor.Controls.DungeonTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager1).BeginInit();
            Toolkit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // poisonStyleManager1
            // 
            poisonStyleManager1.Owner = null;
            poisonStyleManager1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple;
            poisonStyleManager1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // Toolkit
            // 
            Toolkit.BackColor = Color.FromArgb(244, 241, 243);
            Toolkit.BorderColor = Color.FromArgb(175, 192, 255);
            Toolkit.Controls.Add(trackBar1);
            Toolkit.Controls.Add(TemperatureInput);
            Toolkit.Controls.Add(ConvertButton);
            Toolkit.Controls.Add(GardenToolsKill);
            Toolkit.Controls.Add(InputConsole1);
            Toolkit.Controls.Add(OutputConsole1);
            Toolkit.Controls.Add(pictureBox1);
            Toolkit.Dock = DockStyle.Fill;
            Toolkit.FillEdgeColorA = Color.FromArgb(175, 192, 255);
            Toolkit.FillEdgeColorB = Color.FromArgb(175, 192, 255);
            Toolkit.Font = new Font("Segoe UI", 9F);
            Toolkit.FooterEdgeColor = Color.FromArgb(175, 192, 255);
            Toolkit.ForeColor = Color.FromArgb(223, 219, 210);
            Toolkit.HeaderEdgeColorA = Color.FromArgb(175, 192, 255);
            Toolkit.HeaderEdgeColorB = Color.FromArgb(175, 192, 255);
            Toolkit.Location = new Point(0, 0);
            Toolkit.Name = "Toolkit";
            Toolkit.Padding = new Padding(20, 56, 20, 16);
            Toolkit.RoundCorners = true;
            Toolkit.Sizable = false;
            Toolkit.Size = new Size(450, 450);
            Toolkit.SmartBounds = true;
            Toolkit.StartPosition = FormStartPosition.CenterScreen;
            Toolkit.TabIndex = 0;
            Toolkit.Text = "Garden Tools";
            Toolkit.TitleColor = Color.White;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.FromArgb(192, 192, 255);
            trackBar1.Cursor = Cursors.SizeNS;
            trackBar1.Location = new Point(228, 240);
            trackBar1.Maximum = 6;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 179);
            trackBar1.TabIndex = 10;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Value = 1;
            trackBar1.Visible = false;
            trackBar1.Scroll += trackBar1_OnScroll;
            // 
            // TemperatureInput
            // 
            TemperatureInput.BackColor = Color.Transparent;
            TemperatureInput.BorderColor = Color.FromArgb(180, 180, 180);
            TemperatureInput.EdgeColor = Color.White;
            TemperatureInput.Font = new Font("MS Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TemperatureInput.ForeColor = Color.Black;
            TemperatureInput.Location = new Point(64, 278);
            TemperatureInput.MaxLength = 4;
            TemperatureInput.Multiline = false;
            TemperatureInput.Name = "TemperatureInput";
            TemperatureInput.ReadOnly = false;
            TemperatureInput.Size = new Size(46, 26);
            TemperatureInput.TabIndex = 9;
            TemperatureInput.Text = "32";
            TemperatureInput.TextAlignment = HorizontalAlignment.Left;
            TemperatureInput.UseSystemPasswordChar = false;
            // 
            // ConvertButton
            // 
            ConvertButton.BackColor = Color.Transparent;
            ConvertButton.BorderColor = Color.FromArgb(180, 180, 180);
            ConvertButton.Font = new Font("MS Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ConvertButton.Image = null;
            ConvertButton.ImageAlign = ContentAlignment.MiddleLeft;
            ConvertButton.InactiveColorA = Color.FromArgb(253, 252, 252);
            ConvertButton.InactiveColorB = Color.FromArgb(239, 237, 236);
            ConvertButton.Location = new Point(116, 278);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.PressedColorA = Color.FromArgb(226, 226, 226);
            ConvertButton.PressedColorB = Color.FromArgb(237, 237, 237);
            ConvertButton.PressedContourColorA = Color.FromArgb(167, 167, 167);
            ConvertButton.PressedContourColorB = Color.FromArgb(167, 167, 167);
            ConvertButton.Size = new Size(97, 26);
            ConvertButton.TabIndex = 8;
            ConvertButton.Text = "°F to °C";
            ConvertButton.TextAlignment = StringAlignment.Center;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // GardenToolsKill
            // 
            GardenToolsKill.BackColor = Color.Crimson;
            GardenToolsKill.FlatStyle = FlatStyle.Popup;
            GardenToolsKill.Font = new Font("MS Mincho", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GardenToolsKill.Location = new Point(361, 387);
            GardenToolsKill.Name = "GardenToolsKill";
            GardenToolsKill.Size = new Size(55, 32);
            GardenToolsKill.TabIndex = 7;
            GardenToolsKill.Text = "Kill";
            GardenToolsKill.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            GardenToolsKill.UseCustomBackColor = true;
            GardenToolsKill.UseCustomFont = true;
            GardenToolsKill.UseSelectable = true;
            GardenToolsKill.UseVisualStyleBackColor = false;
            GardenToolsKill.Click += GardenToolsKill_Click;
            // 
            // InputConsole1
            // 
            InputConsole1.BackColor = Color.Transparent;
            InputConsole1.BorderColor = Color.FromArgb(180, 180, 180);
            InputConsole1.Font = new Font("MS Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            InputConsole1.Image = null;
            InputConsole1.ImageAlign = ContentAlignment.MiddleLeft;
            InputConsole1.InactiveColorA = Color.FromArgb(253, 252, 252);
            InputConsole1.InactiveColorB = Color.FromArgb(239, 237, 236);
            InputConsole1.Location = new Point(64, 240);
            InputConsole1.Name = "InputConsole1";
            InputConsole1.PressedColorA = Color.FromArgb(226, 226, 226);
            InputConsole1.PressedColorB = Color.FromArgb(237, 237, 237);
            InputConsole1.PressedContourColorA = Color.FromArgb(167, 167, 167);
            InputConsole1.PressedContourColorB = Color.FromArgb(167, 167, 167);
            InputConsole1.Size = new Size(149, 30);
            InputConsole1.TabIndex = 2;
            InputConsole1.Text = "Random Division";
            InputConsole1.TextAlignment = StringAlignment.Center;
            InputConsole1.Click += InputConsole1_Click;
            // 
            // OutputConsole1
            // 
            OutputConsole1.BackColor = Color.Transparent;
            OutputConsole1.BorderColor = Color.Transparent;
            OutputConsole1.EdgeColor = Color.Transparent;
            OutputConsole1.Font = new Font("MS Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutputConsole1.ForeColor = Color.Black;
            OutputConsole1.Location = new Point(64, 68);
            OutputConsole1.MaxLength = 32767;
            OutputConsole1.Multiline = true;
            OutputConsole1.Name = "OutputConsole1";
            OutputConsole1.ReadOnly = true;
            OutputConsole1.Size = new Size(316, 166);
            OutputConsole1.TabIndex = 1;
            OutputConsole1.Text = "OutputConsole";
            OutputConsole1.TextAlignment = HorizontalAlignment.Left;
            OutputConsole1.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.squiggle;
            pictureBox1.Location = new Point(20, 56);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 378);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(Toolkit);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(261, 65);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Garden Tools";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager1).EndInit();
            Toolkit.ResumeLayout(false);
            Toolkit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
        private ReaLTaiizor.Forms.DungeonForm Toolkit;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DungeonTextBox OutputConsole1;
        private ReaLTaiizor.Controls.DungeonButtonLeft InputConsole1;
        private ReaLTaiizor.Controls.PoisonButton GardenToolsKill;
        private ReaLTaiizor.Controls.DungeonButtonLeft ConvertButton;
        private ReaLTaiizor.Controls.DungeonTextBox TemperatureInput;
        private TrackBar trackBar1;
    }
}