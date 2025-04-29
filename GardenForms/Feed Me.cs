using System;
using System.Media;
namespace GardenForms
{
    public partial class Form1 : Form
    {
        //Initial Global Vars for the form
        int timesclicked = 0; //Sets the number of times the button has been clicked to the starting point of 0.



        public Form1()
        {
            InitializeComponent();
            this.Text = "Feed Me";
            progressBar1.Maximum = 124;
            btnClickThis.BackColor = Color.FromArgb(255, 255, 255);
        }

        private async void btnClickThis_Click(object sender, EventArgs e)
        {
            
            timesclicked++;
            BEEPSOUND();
            if (timesclicked == 1)
            {
                btnClickThis.Text = "Thanks. And again?";
            }
            else if (timesclicked == 100)
            {
                FINISHEDJINGLE(); //plays the winning jingle when you hit exactly 100 clicks, but not afterwards.
                btnClickThis.Text = "I'm full now, thanks.";
            }
            else if ((timesclicked > 100) && (timesclicked < 120))
            { //for when the amount of times clicked is more than 100.
                btnClickThis.Text = "I'm full now, thanks.";
            }
            else if (timesclicked == 120)
            {
                btnClickThis.Text = ("Honestly, stop");
            }
            else if ((timesclicked > 120) && (timesclicked <= 124))
            {
                btnClickThis.Text = btnClickThis.Text += ".";
            }
            else if ((timesclicked > 124) && (timesclicked <= 130))
            {
                ShakeThisWindow(this);
                BEEPSOUND();
                BEEPSOUND();
                BEEPSOUND();
            }
            else if (timesclicked > 130)
            {
                this.Close();
            }

            else //Thanks x2, 3, etc combo counter.
            {
                btnClickThis.Text = ("Thanks x" + timesclicked);
            }
            progressBar1.PerformStep();
        }

        private async Task ShakeThisWindow(Form1 form)
        {
            var randomNumber = new Random(50); //generates a random number sequence
            var originalLocation = form.Location; //grabs the original location of the window
            int magnitude = 10;
            for (int s = 0; s < 10; s++)
            {
                form.Location = new Point(originalLocation.X + randomNumber.Next(-magnitude, magnitude), originalLocation.Y + randomNumber.Next(-magnitude, magnitude));
                //Takes original location and applies random x
                await Task.Delay(20);
            }
            form.Location = originalLocation; //resets position of form back to normal
        }

        private void thunderButton1_Click(object sender, EventArgs e)
        {

        }

        private void poisonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task BEEPSOUND() //method that plays M2Blip.wav instead of system beep which lags the main thread.
        {
            byte[] soundEffectFile = Properties.Resources.M2Blip;
            using (var stream = new MemoryStream(soundEffectFile))
            {
                using (var soundPlayer = new SoundPlayer(stream))
                {
                    soundPlayer.Play();
                }
            }
        }

        private async Task FINISHEDJINGLE() //method that plays final jingle
        {
            byte[] soundEffectFile = Properties.Resources.statup;
            using (var stream = new MemoryStream(soundEffectFile))
            {
                using (var soundPlayer = new SoundPlayer(stream))
                {
                    soundPlayer.Play();
                }
            }
            soundEffectFile = Properties.Resources.rfuel;
            using (var stream = new MemoryStream(soundEffectFile))
            {
                using (var soundPlayer = new SoundPlayer(stream))
                {
                    soundPlayer.Play();
                }
            }
        }
    }
}
