namespace GardenForms
{
    partial class ThePaintedWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThePaintedWorld));
            VMU = new PictureBox();
            backClickableSection = new PictureBox();
            drawingZone = new PictureBox();
            trackBar1 = new TrackBar();
            locationControl = new TrackBar();
            scatterAmount = new TrackBar();
            colourControl = new PictureBox();
            ColourButton = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)VMU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backClickableSection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drawingZone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scatterAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colourControl).BeginInit();
            SuspendLayout();
            // 
            // VMU
            // 
            VMU.Image = Properties.Resources.VMU3;
            VMU.Location = new Point(0, 0);
            VMU.Name = "VMU";
            VMU.Size = new Size(383, 641);
            VMU.TabIndex = 0;
            VMU.TabStop = false;
            VMU.MouseDown += VMU_MouseDown;
            VMU.MouseMove += VMU_MouseMove;
            VMU.MouseUp += VMU_MouseUp;
            // 
            // backClickableSection
            // 
            backClickableSection.Image = Properties.Resources.backsection;
            backClickableSection.Location = new Point(266, 460);
            backClickableSection.Name = "backClickableSection";
            backClickableSection.Size = new Size(77, 103);
            backClickableSection.TabIndex = 1;
            backClickableSection.TabStop = false;
            backClickableSection.Click += backClickableSection_Click;
            backClickableSection.MouseEnter += backButton_Enter;
            backClickableSection.MouseLeave += backButton_StopHover;
            backClickableSection.MouseHover += backButton_Hover;
            // 
            // drawingZone
            // 
            drawingZone.Image = Properties.Resources.vmuback;
            drawingZone.Location = new Point(67, 185);
            drawingZone.Name = "drawingZone";
            drawingZone.Size = new Size(246, 206);
            drawingZone.TabIndex = 2;
            drawingZone.TabStop = false;
            drawingZone.Click += drawingZone_Click;
            drawingZone.Paint += drawingZone_OnPaint;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.Red;
            trackBar1.Location = new Point(417, 166);
            trackBar1.Maximum = 300;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 246);
            trackBar1.TabIndex = 3;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 70;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // locationControl
            // 
            locationControl.BackColor = Color.Red;
            locationControl.Location = new Point(445, 166);
            locationControl.Maximum = 300;
            locationControl.Minimum = 1;
            locationControl.Name = "locationControl";
            locationControl.Orientation = Orientation.Vertical;
            locationControl.Size = new Size(45, 246);
            locationControl.TabIndex = 4;
            locationControl.TickStyle = TickStyle.None;
            locationControl.Value = 70;
            locationControl.Scroll += adjustLocation;
            // 
            // scatterAmount
            // 
            scatterAmount.BackColor = Color.Red;
            scatterAmount.Location = new Point(389, 166);
            scatterAmount.Maximum = 100;
            scatterAmount.Minimum = -30;
            scatterAmount.Name = "scatterAmount";
            scatterAmount.Orientation = Orientation.Vertical;
            scatterAmount.Size = new Size(45, 246);
            scatterAmount.TabIndex = 5;
            scatterAmount.TickStyle = TickStyle.None;
            scatterAmount.Scroll += scatterAmount_Scroll;
            // 
            // colourControl
            // 
            colourControl.Image = Properties.Resources.colour;
            colourControl.Location = new Point(227, 139);
            colourControl.Name = "colourControl";
            colourControl.Size = new Size(86, 30);
            colourControl.TabIndex = 6;
            colourControl.TabStop = false;
            colourControl.Click += colourControl_Click;
            // 
            // ColourButton
            // 
            ColourButton.BorderColor = Color.FromArgb(220, 223, 230);
            ColourButton.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            ColourButton.DangerColor = Color.FromArgb(245, 108, 108);
            ColourButton.DefaultColor = Color.FromArgb(255, 255, 255);
            ColourButton.Font = new Font("MS Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColourButton.HoverTextColor = Color.FromArgb(48, 49, 51);
            ColourButton.InfoColor = Color.FromArgb(144, 147, 153);
            ColourButton.Location = new Point(389, 120);
            ColourButton.Name = "ColourButton";
            ColourButton.PrimaryColor = Color.FromArgb(64, 158, 255);
            ColourButton.Size = new Size(73, 40);
            ColourButton.SuccessColor = Color.FromArgb(103, 194, 58);
            ColourButton.TabIndex = 7;
            ColourButton.Text = "Colour";
            ColourButton.TextColor = Color.White;
            ColourButton.WarningColor = Color.FromArgb(230, 162, 60);
            ColourButton.Click += ColourButton_Click;
            // 
            // ThePaintedWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.macwindowmask;
            ClientSize = new Size(546, 653);
            Controls.Add(ColourButton);
            Controls.Add(colourControl);
            Controls.Add(locationControl);
            Controls.Add(trackBar1);
            Controls.Add(drawingZone);
            Controls.Add(backClickableSection);
            Controls.Add(VMU);
            Controls.Add(scatterAmount);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ThePaintedWorld";
            Text = "ThePaintedWorld";
            TransparencyKey = Color.Red;
            ((System.ComponentModel.ISupportInitialize)VMU).EndInit();
            ((System.ComponentModel.ISupportInitialize)backClickableSection).EndInit();
            ((System.ComponentModel.ISupportInitialize)drawingZone).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)scatterAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)colourControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox VMU;
        private PictureBox pictureBox1;
        private PictureBox backClickableSection;
        private PictureBox drawingZone;
        private TrackBar trackBar1;
        private TrackBar locationControl;
        private TrackBar scatterAmount;
        private PictureBox colourControl;
        private ReaLTaiizor.Controls.HopeButton ColourButton;
    }
}