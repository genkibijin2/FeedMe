using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenForms
{
    public partial class Form2 : Form
    {
        
        string initialText = "Output Console...";
        string currentUserInput = "";
        public Form2()
        {
            InitializeComponent();
            InputConsole.Visible = false;
            Size = new Size(450, 450);
            ConsoleConversation(); //"Main" function of form, which is the conversation with the output console.
            
        }

        private async Task outputToConsole(string currentMessage) //Method that creates a typewriter effect on the text, with async 
        {

            string currentStackOfChars = "";
            for (int i = 0; i < currentMessage.Length; i++)
            {
                currentStackOfChars = currentStackOfChars + (currentMessage[i]);
                OutputConsole1.Text = currentStackOfChars;
                await Task.Delay(100);
            }
            //This lets me test out async/await methods to draw the text without the delays/sleeps affecting the drawing of the .gif background graphics.
        }

        private async Task suspiciousDots()
        {
            string currentStackOfChars = OutputConsole1.Text;
            for (int m = 0; m <= 6; m++)
            {
                await Task.Delay(500);
                currentStackOfChars = currentStackOfChars + ".";
                OutputConsole1.Text = currentStackOfChars;
            }
        }

        private void dungeonForm1_Click(object sender, EventArgs e)
        {
            
        }

        private void Background_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task ConsoleConversation()
        {
            await outputToConsole(initialText); //Print opening text to console, and wait for method to finish.
            await suspiciousDots();
            await outputToConsole("What is your name?");
            InputConsole.Visible = true;
        }
    }
}
