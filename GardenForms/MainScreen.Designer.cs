namespace GardenForms
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            pictureBox1 = new PictureBox();
            FeedMeCard = new PictureBox();
            GardenToolsBox = new PictureBox();
            mahjongBetBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedMeCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GardenToolsBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mahjongBetBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bg0061;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.bg006;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(874, 457);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FeedMeCard
            // 
            FeedMeCard.BackgroundImage = Properties.Resources.I_B_CARD14_TMX_1BRIGHT;
            FeedMeCard.Image = Properties.Resources.I_B_CARD14_TMX_1;
            FeedMeCard.Location = new Point(39, 24);
            FeedMeCard.Name = "FeedMeCard";
            FeedMeCard.Size = new Size(98, 126);
            FeedMeCard.TabIndex = 2;
            FeedMeCard.TabStop = false;
            FeedMeCard.Click += FeedMeCard_Click;
            FeedMeCard.MouseLeave += FeedMeCard_Leave;
            FeedMeCard.MouseHover += FeedMeCard_Hover;
            // 
            // GardenToolsBox
            // 
            GardenToolsBox.BackgroundImage = Properties.Resources.ToolBoxCard;
            GardenToolsBox.Image = Properties.Resources.ToolBoxCard;
            GardenToolsBox.Location = new Point(274, 24);
            GardenToolsBox.Name = "GardenToolsBox";
            GardenToolsBox.Size = new Size(98, 126);
            GardenToolsBox.TabIndex = 3;
            GardenToolsBox.TabStop = false;
            GardenToolsBox.Click += GardenToolsBox_Click;
            GardenToolsBox.MouseLeave += GardenToolsBox_Leave;
            GardenToolsBox.MouseHover += GardenToolsBox_Hover;
            // 
            // mahjongBetBox
            // 
            mahjongBetBox.BackgroundImage = Properties.Resources.MahjongCard;
            mahjongBetBox.Image = Properties.Resources.MahjongCard;
            mahjongBetBox.Location = new Point(604, 24);
            mahjongBetBox.Name = "mahjongBetBox";
            mahjongBetBox.Size = new Size(98, 126);
            mahjongBetBox.TabIndex = 4;
            mahjongBetBox.TabStop = false;
            mahjongBetBox.Click += mahjongBetBox_Click;
            mahjongBetBox.MouseLeave += mahjongBetBox_MouseLeave;
            mahjongBetBox.MouseHover += mahjongBetBox_Hover;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 457);
            Controls.Add(mahjongBetBox);
            Controls.Add(GardenToolsBox);
            Controls.Add(FeedMeCard);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Help;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kendalls.Garden";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedMeCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)GardenToolsBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mahjongBetBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox FeedMeCard;
        private PictureBox GardenToolsBox;
        private PictureBox mahjongBetBox;
    }
}