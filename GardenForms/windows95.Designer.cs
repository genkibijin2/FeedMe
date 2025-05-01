namespace GardenForms
{
    partial class windows95
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windows95));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            OutPutTopBox = new TextBox();
            tileSlot1 = new PictureBox();
            tileSlot2 = new PictureBox();
            tileSlot3 = new PictureBox();
            tileSlot4 = new PictureBox();
            tileSlot5 = new PictureBox();
            BetButton = new ReaLTaiizor.Controls.HopeButton();
            ScoreBox = new Label();
            DemonScoreBox = new Label();
            PlayerTurnButton = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.untitledpaint;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 340);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += windows95_MouseDown;
            pictureBox1.MouseMove += windows95_MouseMove;
            pictureBox1.MouseUp += windows95_MouseUp;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.exit;
            pictureBox3.Location = new Point(427, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 14);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.paintbackground;
            pictureBox4.Location = new Point(68, 45);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(365, 275);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // OutPutTopBox
            // 
            OutPutTopBox.Font = new Font("MS Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutPutTopBox.Location = new Point(78, 54);
            OutPutTopBox.Name = "OutPutTopBox";
            OutPutTopBox.ReadOnly = true;
            OutPutTopBox.Size = new Size(343, 23);
            OutPutTopBox.TabIndex = 3;
            OutPutTopBox.Text = "hello";
            OutPutTopBox.TextAlign = HorizontalAlignment.Center;
            // 
            // tileSlot1
            // 
            tileSlot1.Image = Properties.Resources.jongback;
            tileSlot1.Location = new Point(89, 100);
            tileSlot1.Name = "tileSlot1";
            tileSlot1.Size = new Size(59, 73);
            tileSlot1.TabIndex = 4;
            tileSlot1.TabStop = false;
            tileSlot1.Visible = false;
            // 
            // tileSlot2
            // 
            tileSlot2.Image = Properties.Resources.jongback;
            tileSlot2.Location = new Point(154, 100);
            tileSlot2.Name = "tileSlot2";
            tileSlot2.Size = new Size(59, 73);
            tileSlot2.TabIndex = 5;
            tileSlot2.TabStop = false;
            tileSlot2.Visible = false;
            // 
            // tileSlot3
            // 
            tileSlot3.Image = Properties.Resources.jongback;
            tileSlot3.Location = new Point(219, 100);
            tileSlot3.Name = "tileSlot3";
            tileSlot3.Size = new Size(59, 73);
            tileSlot3.TabIndex = 6;
            tileSlot3.TabStop = false;
            tileSlot3.Visible = false;
            // 
            // tileSlot4
            // 
            tileSlot4.Image = Properties.Resources.jongback;
            tileSlot4.Location = new Point(284, 100);
            tileSlot4.Name = "tileSlot4";
            tileSlot4.Size = new Size(59, 73);
            tileSlot4.TabIndex = 7;
            tileSlot4.TabStop = false;
            tileSlot4.Visible = false;
            // 
            // tileSlot5
            // 
            tileSlot5.Image = Properties.Resources.jongback;
            tileSlot5.Location = new Point(349, 100);
            tileSlot5.Name = "tileSlot5";
            tileSlot5.Size = new Size(59, 73);
            tileSlot5.TabIndex = 8;
            tileSlot5.TabStop = false;
            tileSlot5.Visible = false;
            // 
            // BetButton
            // 
            BetButton.BorderColor = Color.FromArgb(220, 223, 230);
            BetButton.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            BetButton.DangerColor = Color.FromArgb(245, 108, 108);
            BetButton.DefaultColor = Color.FromArgb(255, 255, 255);
            BetButton.Font = new Font("MS Mincho", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BetButton.HoverTextColor = Color.FromArgb(48, 49, 51);
            BetButton.InfoColor = Color.FromArgb(144, 147, 153);
            BetButton.Location = new Point(219, 269);
            BetButton.Name = "BetButton";
            BetButton.PrimaryColor = Color.FromArgb(192, 255, 192);
            BetButton.Size = new Size(59, 40);
            BetButton.SuccessColor = Color.FromArgb(103, 194, 58);
            BetButton.TabIndex = 9;
            BetButton.Text = "Play";
            BetButton.TextColor = Color.Black;
            BetButton.Visible = false;
            BetButton.WarningColor = Color.FromArgb(230, 162, 60);
            BetButton.Click += BetButton_Click;
            // 
            // ScoreBox
            // 
            ScoreBox.AutoSize = true;
            ScoreBox.Font = new Font("MS Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreBox.Location = new Point(289, 210);
            ScoreBox.Name = "ScoreBox";
            ScoreBox.Size = new Size(119, 16);
            ScoreBox.TabIndex = 10;
            ScoreBox.Text = "Round Score: 0";
            ScoreBox.Visible = false;
            // 
            // DemonScoreBox
            // 
            DemonScoreBox.AutoSize = true;
            DemonScoreBox.Font = new Font("MS Mincho", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DemonScoreBox.Location = new Point(289, 185);
            DemonScoreBox.Name = "DemonScoreBox";
            DemonScoreBox.Size = new Size(119, 16);
            DemonScoreBox.TabIndex = 11;
            DemonScoreBox.Text = "Demon Score: 0";
            DemonScoreBox.Visible = false;
            // 
            // PlayerTurnButton
            // 
            PlayerTurnButton.BorderColor = Color.FromArgb(220, 223, 230);
            PlayerTurnButton.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            PlayerTurnButton.DangerColor = Color.FromArgb(245, 108, 108);
            PlayerTurnButton.DefaultColor = Color.FromArgb(255, 255, 255);
            PlayerTurnButton.Font = new Font("MS Mincho", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerTurnButton.HoverTextColor = Color.FromArgb(48, 49, 51);
            PlayerTurnButton.InfoColor = Color.FromArgb(144, 147, 153);
            PlayerTurnButton.Location = new Point(316, 246);
            PlayerTurnButton.Name = "PlayerTurnButton";
            PlayerTurnButton.PrimaryColor = Color.FromArgb(255, 128, 128);
            PlayerTurnButton.Size = new Size(92, 40);
            PlayerTurnButton.SuccessColor = Color.FromArgb(103, 194, 58);
            PlayerTurnButton.TabIndex = 12;
            PlayerTurnButton.Text = "My Turn";
            PlayerTurnButton.TextColor = Color.Black;
            PlayerTurnButton.Visible = false;
            PlayerTurnButton.WarningColor = Color.FromArgb(230, 162, 60);
            PlayerTurnButton.Click += PlayerTurnButton_Click;
            // 
            // windows95
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 340);
            Controls.Add(PlayerTurnButton);
            Controls.Add(DemonScoreBox);
            Controls.Add(ScoreBox);
            Controls.Add(BetButton);
            Controls.Add(tileSlot5);
            Controls.Add(tileSlot4);
            Controls.Add(tileSlot3);
            Controls.Add(tileSlot2);
            Controls.Add(tileSlot1);
            Controls.Add(OutPutTopBox);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "windows95";
            StartPosition = FormStartPosition.CenterParent;
            Text = "windows95";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot4).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileSlot5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox OutPutTopBox;
        private PictureBox tileSlot1;
        private PictureBox tileSlot2;
        private PictureBox tileSlot3;
        private PictureBox tileSlot4;
        private PictureBox tileSlot5;
        private ReaLTaiizor.Controls.HopeButton BetButton;
        private Label ScoreBox;
        private Label DemonScoreBox;
        private ReaLTaiizor.Controls.HopeButton PlayerTurnButton;
    }
}