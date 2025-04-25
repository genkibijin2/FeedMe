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
            InputConsole = new ReaLTaiizor.Controls.DungeonRichTextBox();
            OutputConsole1 = new ReaLTaiizor.Controls.DungeonTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager1).BeginInit();
            Toolkit.SuspendLayout();
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
            Toolkit.Controls.Add(InputConsole);
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
            // InputConsole
            // 
            InputConsole.AutoWordSelection = false;
            InputConsole.BackColor = Color.Transparent;
            InputConsole.BorderColor = Color.FromArgb(180, 180, 180);
            InputConsole.EdgeColor = Color.White;
            InputConsole.Font = new Font("MS Mincho", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputConsole.ForeColor = Color.Black;
            InputConsole.Location = new Point(64, 254);
            InputConsole.Name = "InputConsole";
            InputConsole.ReadOnly = false;
            InputConsole.Size = new Size(316, 33);
            InputConsole.TabIndex = 2;
            InputConsole.Text = "Type here";
            InputConsole.TextBackColor = Color.White;
            InputConsole.Visible = false;
            InputConsole.WordWrap = true;
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
            pictureBox1.Click += Background_click;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
        private ReaLTaiizor.Forms.DungeonForm Toolkit;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DungeonTextBox OutputConsole1;
        private ReaLTaiizor.Controls.DungeonRichTextBox InputConsole;
    }
}