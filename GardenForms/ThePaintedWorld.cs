using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GardenForms
{
    public partial class ThePaintedWorld : Form
    {
        //Setup for window to be transparent, have a custom border, but still be clickable/draggable
        //------------------------------------------------------------------------------------------
        private bool mouseDown;
        private Point lastLocation;
        int rotationAngle = 0;
        int currentSize = 100; //dimensions - height and width of rectangle.
        int currentPositionLeft = 1;
        int currentPositionDown = 1;
        float currentTranslationx = 0F;
        float currentTranslationy = 0F;
        int colourSelection = 1;
        private void VMU_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void VMU_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void VMU_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //-----------------------------------------------------------------------------------------
        //End of window draggable zone setup
        public ThePaintedWorld()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void backClickableSection_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Hover(object sender, EventArgs e)
        {
            backClickableSection.Image = Properties.Resources.backsectionHighLight;
        }

        private void backButton_StopHover(object sender, EventArgs e)
        {
            backClickableSection.Image = Properties.Resources.backsection;
        }

        private void drawingZone_OnPaint(object sender, PaintEventArgs e)
        {
            theRotatingCube(e);
        }


        private async Task theRotatingCube(PaintEventArgs e)
        {

            for (int r = 1; r <= 100; r++)
            {
                await drawTheThing(e, rotationAngle);
                //await Task.Delay(90);
                rotationAngle++;
                Invalidate();
            }

        }

        private async Task drawTheThing(PaintEventArgs e, int currentRotationAngle)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(currentPositionLeft, currentPositionDown, currentSize, currentSize);
            g.RotateTransform(currentRotationAngle, MatrixOrder.Append);
            g.TranslateTransform(currentTranslationx, currentTranslationy);
            LinearGradientBrush col1brush = new LinearGradientBrush(rect, Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            LinearGradientBrush col2brush = new LinearGradientBrush(rect, Color.LimeGreen, Color.Purple, LinearGradientMode.BackwardDiagonal);
            LinearGradientBrush col3brush = new LinearGradientBrush(rect, Color.DeepSkyBlue, Color.White, LinearGradientMode.BackwardDiagonal);
            LinearGradientBrush col4brush = new LinearGradientBrush(rect, Color.BlueViolet, Color.Orange, LinearGradientMode.BackwardDiagonal);

            switch (colourSelection)
            {
                case 1:
                    g.FillRectangle(col1brush, rect);
                    break;
                case 2:
                    g.FillRectangle(col2brush, rect);
                    break;
                case 3:
                    g.FillRectangle(col3brush, rect);
                    break;
                case 4:
                    g.FillRectangle(col4brush, rect);
                    break;
            }
        }

        private void drawingZone_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentSize = trackBar1.Value;
        }

        private void adjustLocation(object sender, EventArgs e)
        {
            currentPositionLeft = locationControl.Value;
            currentPositionDown = locationControl.Value;
        }

        private void scatterAmount_Scroll(object sender, EventArgs e)
        {
            currentTranslationx = scatterAmount.Value;
            currentTranslationy = scatterAmount.Value;
        }

        private void colourControl_Click(object sender, EventArgs e)
        {

        }

        private void ColourButton_Click(object sender, EventArgs e)
        {
            if (colourSelection < 4)
            {
                colourSelection++;
            }
            else
            {
                colourSelection = 1;
            }
        }

        private void backButton_Enter(object sender, EventArgs e)
        {
            backClickableSection.Image = Properties.Resources.backsectionHighLight;
        }
    }
}
