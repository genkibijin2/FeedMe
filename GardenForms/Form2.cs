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
            InputConsole1.Visible = false;
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

        

        private async Task ConsoleConversation()
        {
            await outputToConsole(initialText); //Print opening text to console, and wait for method to finish.
            await suspiciousDots();
            await outputToConsole("What would you like?");
            InputConsole1.Text = "Random Division";
            InputConsole1.Visible = true;
        }

        private void InputConsole1_Click(object sender, EventArgs e) //Clicking the first program button
        {
            Program1();
        }

        private async Task Program1() //currently worked on C# Task from microsoft
        {
            string program1Output = ""; //Initialize console output (blank)
            //---------------------------------------------------------------------
            Random rnd = new Random();
            await outputToConsole("Generating a number between 1 and 10,000...");
            int number1 = rnd.Next(1, 10000);
            await outputToConsole($"Generated {number1}");
            await suspiciousDots();
            await outputToConsole("Generating second number between 1 and 10...");
            int number2 = rnd.Next(1, 10);
            await outputToConsole($"Generated {number2}");
            await suspiciousDots();
            await outputToConsole($"Dividing {number1} by {number2}...");
            int modResult = number1 % number2;
            if (modResult == 0)
            {
                program1Output = $"{number1} is cleanly divisible by {number2}... Wow!";
            }
            else
            {
                program1Output = $"Looks like {number1} cannot be divided by {number2}... What a shame!";
            }
            //---------------------------------------------------------------------
            await outputToConsole(program1Output); //Write final output to console.
        }

        private void GardenToolsKill_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
