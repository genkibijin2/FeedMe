using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenForms
{
    public partial class windows95 : Form
    {
        bool isCurrentTaskFinished = true;
        string initialText = "Hello... These are my tiles";
        public windows95()
        {
            InitializeComponent();
            mahJongGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Setup for window to be transparent, have a custom border, but still be clickable/draggable
        //------------------------------------------------------------------------------------------
        private bool mouseDown;
        private Point lastLocation;

        private void windows95_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void windows95_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void windows95_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //-----------------------------------------------------------------------------------------
        //End of window draggable zone setup

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task outputToConsole(string currentMessage) //Method that creates a typewriter effect on the text, with async 
        {
            //42 character line limit before you should recall method.
            string currentStackOfChars = "";
            for (int i = 0; i < currentMessage.Length; i++)
            {
                currentStackOfChars = currentStackOfChars + (currentMessage[i]);
               OutPutTopBox.Text = currentStackOfChars;
                await Task.Delay(50);
            }
            //This lets me test out async/await methods to draw the text without the delays/sleeps affecting the drawing of the .gif background graphics.
        }

        private async Task displayInitialTiles() //shows initial selection of turned down tiles.
        { //add sfx to this
            tileSlot1.Visible = true;
            //playTileSound();
            await Task.Delay(70);
            tileSlot2.Visible = true;
            //await playTileSound();
            await Task.Delay(70);
            tileSlot3.Visible = true;
            //playTileSound();
            await Task.Delay(70);
            tileSlot4.Visible = true;
            //playTileSound();
            await Task.Delay(70);
            tileSlot5.Visible = true;
            //playTileSound();
            await Task.Delay(70);
        }

        private async Task mahJongGame()
        {
            await outputToConsole(initialText);
            await displayInitialTiles();
        }
    }
}
