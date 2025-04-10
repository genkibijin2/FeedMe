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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnClickThis = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Font = new Font("CozetteCrossedSevenVector", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClickThis.Location = new Point(12, 10);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(287, 73);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Click this";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 88);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(287, 57);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 156);
            Controls.Add(progressBar1);
            Controls.Add(btnClickThis);
            Font = new Font("CozetteCrossedSevenVector", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickThis;
        private ProgressBar progressBar1;
    }
}
