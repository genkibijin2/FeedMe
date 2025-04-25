namespace GardenForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            btnClickThis = new Button();
            pictureBox1 = new PictureBox();
            dungeonForm1 = new ReaLTaiizor.Forms.DungeonForm();
            poisonButton1 = new ReaLTaiizor.Controls.PoisonButton();
            poisonStyleManager1 = new ReaLTaiizor.Manager.PoisonStyleManager(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            dungeonForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(44, 157);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(287, 28);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 4;
            // 
            // btnClickThis
            // 
            btnClickThis.BackColor = Color.FromArgb(192, 192, 255);
            btnClickThis.Cursor = Cursors.Hand;
            btnClickThis.Font = new Font("MS Mincho", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClickThis.ForeColor = Color.Black;
            btnClickThis.Location = new Point(44, 69);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(287, 73);
            btnClickThis.TabIndex = 3;
            btnClickThis.Text = "Please Feed Me";
            btnClickThis.UseVisualStyleBackColor = false;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.squiggle;
            pictureBox1.Location = new Point(20, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 191);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dungeonForm1
            // 
            dungeonForm1.BackColor = Color.Aquamarine;
            dungeonForm1.BorderColor = Color.Plum;
            dungeonForm1.Controls.Add(poisonButton1);
            dungeonForm1.Controls.Add(progressBar1);
            dungeonForm1.Controls.Add(btnClickThis);
            dungeonForm1.Controls.Add(pictureBox1);
            dungeonForm1.Cursor = Cursors.Hand;
            dungeonForm1.Dock = DockStyle.Fill;
            dungeonForm1.FillEdgeColorA = Color.Plum;
            dungeonForm1.FillEdgeColorB = Color.Plum;
            dungeonForm1.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dungeonForm1.FooterEdgeColor = Color.Plum;
            dungeonForm1.ForeColor = Color.White;
            dungeonForm1.HeaderEdgeColorA = Color.Plum;
            dungeonForm1.HeaderEdgeColorB = Color.Plum;
            dungeonForm1.Location = new Point(0, 0);
            dungeonForm1.Name = "dungeonForm1";
            dungeonForm1.Padding = new Padding(20, 56, 20, 16);
            dungeonForm1.RoundCorners = true;
            dungeonForm1.Sizable = false;
            dungeonForm1.Size = new Size(382, 263);
            dungeonForm1.SmartBounds = true;
            dungeonForm1.StartPosition = FormStartPosition.CenterScreen;
            dungeonForm1.TabIndex = 6;
            dungeonForm1.Text = "Feed Me";
            dungeonForm1.TitleColor = Color.White;
            // 
            // poisonButton1
            // 
            poisonButton1.BackColor = Color.Crimson;
            poisonButton1.FlatStyle = FlatStyle.Popup;
            poisonButton1.Font = new Font("MS Mincho", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poisonButton1.Location = new Point(276, 191);
            poisonButton1.Name = "poisonButton1";
            poisonButton1.Size = new Size(55, 32);
            poisonButton1.TabIndex = 6;
            poisonButton1.Text = "Kill";
            poisonButton1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            poisonButton1.UseCustomBackColor = true;
            poisonButton1.UseCustomFont = true;
            poisonButton1.UseSelectable = true;
            poisonButton1.UseVisualStyleBackColor = false;
            poisonButton1.Click += poisonButton1_Click;
            // 
            // poisonStyleManager1
            // 
            poisonStyleManager1.Owner = null;
            poisonStyleManager1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 263);
            Controls.Add(dungeonForm1);
            Font = new Font("CozetteCrossedSevenVector", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(261, 65);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feed Me";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            dungeonForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)poisonStyleManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btnClickThis;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Forms.DungeonForm dungeonForm1;
        private ReaLTaiizor.Controls.PoisonButton poisonButton1;
        private ReaLTaiizor.Manager.PoisonStyleManager poisonStyleManager1;
    }
}
