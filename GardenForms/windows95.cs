using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdamsLair.WinForms.Properties;
using ReaLTaiizor.Animate.Metro;

namespace GardenForms
{
    public partial class windows95 : Form
    {
        bool isCurrentTaskFinished = true;
        int roundNumber = 1;
        int demonFinalScore = 0;
        int playerFinalScore = 0;
        string initialText = "Hello... These are my tiles";
        public windows95()
        {
            InitializeComponent();
            mahJongSetup();
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
            await Task.Delay(300);
            await outputToConsole("Would you like to place a bet?");
            BetButton.Visible = true;
        }

        private async Task mahJongSetup() //setup game.
        {

            await outputToConsole(initialText);
            await displayInitialTiles();
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            roundNumber = 1;
            BetButton.Visible = false;
            StartRound1();
        }

        private async Task StartRound1() //first game round.
        {
            int finalScore = 0;
            await outputToConsole("I'll draw my tiles...");
            await DMRoll();
            PlayerTurnButton.Visible = true;
        }

        private async Task DMRoll() //generates random numbers and shows tile swap animation before pulling out random score with associated tile.
        {
            DemonScoreBox.Visible = true;

            Random tileDraw = new Random();
            int randomImagePicked = 0;
            int totalHandScore = 0;
            for (int spinner = 1; spinner <= 70; spinner++) //animate tileslot 1
            //NOTE: I wanted this to be a method that could be reused with the current slot referenced like an array, but I'm currently unsure how to code this.
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot1.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            DemonScoreBox.Text = $"Demon Score: {totalHandScore}";

            for (int spinner = 1; spinner <= 15; spinner++) //animate tileslot 2
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot2.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            DemonScoreBox.Text = $"Demon Score: {totalHandScore}";

            for (int spinner = 1; spinner <= 15; spinner++) //animate tileslot 2
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot3.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            DemonScoreBox.Text = $"Demon Score: {totalHandScore}";

            for (int spinner = 1; spinner <= 15; spinner++) //animate tileslot 2
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot4.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            DemonScoreBox.Text = $"Demon Score: {totalHandScore}";

            for (int spinner = 1; spinner <= 15; spinner++) //animate tileslot 2
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot5.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            DemonScoreBox.Text = $"Demon Score: {totalHandScore}";

            //Choose Result Response
            if (totalHandScore <= 10)
            {
                await outputToConsole($"{totalHandScore}... Unfortunate...");
            }
            else if (totalHandScore > 10 && totalHandScore <= 20)
            {
                await outputToConsole($"{totalHandScore}? Not terrible...");
            }
            else if (totalHandScore > 20 && totalHandScore <= 30)
            {
                await outputToConsole($"{totalHandScore}! Your turn...");
            }
            else if (totalHandScore > 30 && totalHandScore <= 40)
            {
                await outputToConsole($"{totalHandScore}! Good luck...");
            }
            else
            {
                await outputToConsole($"{totalHandScore}!! Not your luckiest day, is it?");
            }
            demonFinalScore = totalHandScore;
        }

        private Image tileSelect(int currentPick) //generates random tile images for animation
        {
            switch (currentPick)
            {
                case 1:
                    return Properties.Resources.jong1;
                    break;
                case 2:
                    return Properties.Resources.jong2;
                    break;
                case 3:
                    return Properties.Resources.jong3;
                    break;
                case 4:
                    return Properties.Resources.jong4;
                    break;
                case 5:
                    return Properties.Resources.jong5;
                    break;
                case 6:
                    return Properties.Resources.jong6;
                    break;
                case 7:
                    return Properties.Resources.jong7;
                    break;
                case 8:
                    return Properties.Resources.jong8;
                    break;
                case 9:
                    return Properties.Resources.jong9;
                    break;
            }
            return Properties.Resources.jong1;
        }

        private void PlayerTurnButton_Click(object sender, EventArgs e)
        {
            beginPlayerTurn();
        }

        private async Task beginPlayerTurn()
        {
            PlayerTurnButton.Visible = false;
            await reformatTiles();
            await outputToConsole("Let's see how you fare...");
            ScoreBox.Visible = true; //same setup as demon turn
            Random tileDraw = new Random();
            int randomImagePicked = 0;
            int totalHandScore = 0;
            for (int spinner = 1; spinner <= 70; spinner++) //animate tileslot 1
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot1.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            ScoreBox.Text = $"Round Score: {totalHandScore}";

            for (int spinner = 1; spinner <= 15; spinner++) //animate tileslot 1
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot2.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            ScoreBox.Text = $"Round Score: {totalHandScore}";

            for (int spinner = 1; spinner <= 15; spinner++) //animate tileslot 1
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot3.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            ScoreBox.Text = $"Round Score: {totalHandScore}";

            for (int spinner = 1; spinner <= 15; spinner++) //animate tileslot 1
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot4.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            ScoreBox.Text = $"Round Score: {totalHandScore}";

            for (int spinner = 1; spinner <= 15; spinner++) //animate tileslot 1
            {
                randomImagePicked = tileDraw.Next(1, 9);
                tileSlot5.Image = tileSelect(randomImagePicked);
                await Task.Delay(40);
            }
            totalHandScore = totalHandScore + randomImagePicked;
            ScoreBox.Text = $"Round Score: {totalHandScore}";
            playerFinalScore = totalHandScore;
            if (playerFinalScore > demonFinalScore)
            {
                await outputToConsole($"{playerFinalScore}?? Hmm...");
                await Task.Delay(70);
                await outputToConsole("You win this time...");
            }
            else if (demonFinalScore > playerFinalScore)
            {
                await outputToConsole($"Only {playerFinalScore}? How unfortunate.");
                await Task.Delay(70);
                await outputToConsole("You'll have to get luckier next time...");
            }
            else //draw
            {
                await outputToConsole("What are the chances of that?...");
                await outputToConsole($"We both got {playerFinalScore}...");
                await outputToConsole("No winners this time...");
            }
            await Task.Delay(100);
            await reformatTiles();
            BetButton.Visible = true;
        }

        private async Task reformatTiles() //resets the tiles back to blank.
        {
            tileSlot1.Image = Properties.Resources.jongback;
            await Task.Delay(70);
            tileSlot2.Image = Properties.Resources.jongback;
            await Task.Delay(70);
            tileSlot3.Image = Properties.Resources.jongback;
            await Task.Delay(70);
            tileSlot4.Image = Properties.Resources.jongback;
            await Task.Delay(70);
            tileSlot5.Image = Properties.Resources.jongback;
            await Task.Delay(70);
        }
    }
}
