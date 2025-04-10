using System;
namespace GardenForms
{
    public partial class Form1 : Form
    {
        int timesclicked = 0; //Sets the number of times the button has been clicked to the starting point of 0.
        public Form1()
        {
            InitializeComponent();
            this.Text = "Feed Me";
            progressBar1.Maximum = 100;
        }

        private void btnClickThis_Click(object sender, EventArgs e)
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
            else if (timesclicked > 100) { //for when the amount of times clicked is more than 100.
                btnClickThis.Text = "I'm full now, thanks.";

            }
            else
            {
                btnClickThis.Text = ("Thanks x" + timesclicked);
            }
            progressBar1.PerformStep();
        }

        public void successJingle()
        {
            //frequencies
            int C = 525;
            int Cs = 554;
            int D = 587;
            int Ds = 622;
            int E = 659;
            int F = 698;
            int Fs = 739;
            int G = 784;
            int Gs = 830;
            int A = 880;
            int As = 932;
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
       

       

       
    }
}
