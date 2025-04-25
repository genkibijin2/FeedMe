using System;
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
            Console.Beep((timesclicked * 15 + 37), 40);
            if (timesclicked == 1)
            {
                btnClickThis.Text = "Thanks. And again?";
            }
            else if (timesclicked == 100)
            {
                successJingle(); //plays the winning jingle when you hit exactly 100 clicks, but not afterwards.
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
                Console.Beep(750, 10);
                Console.Beep(750, 10);
                Console.Beep(750, 10);
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

        public void successJingle()
        {
            //frequencies
            int E = 659;
            int F = 698;
            int G = 784;
            int Gs = 830;
            int A = 880;
            int B = 987;

            //tempo
            int T = 100;

            Console.Beep(B, T);
            Console.Beep(A, T);
            Console.Beep(B, T);
            Console.Beep(F, T);
            Console.Beep(B, T);
            Console.Beep(G, T);
            Console.Beep(B, T);
            Console.Beep(E, T);
            Console.Beep(B, T);
            Console.Beep(Gs, T);
            Console.Beep(B, T);
        }

        private static void ShakeThisWindow(Form1 form)
        {
            var randomNumber = new Random(50); //generates a random number sequence
            var originalLocation = form.Location; //grabs the original location of the window
            int magnitude = 10;
            for (int s = 0; s < 10; s++)
            {
                form.Location = new Point(originalLocation.X + randomNumber.Next(-magnitude, magnitude), originalLocation.Y + randomNumber.Next(-magnitude, magnitude));
                //Takes original location and applies random x
                System.Threading.Thread.Sleep(20);
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
    }
}
