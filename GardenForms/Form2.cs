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
        bool isCurrentTaskFinished = true;
        string initialText = "Output Console...";
        string currentUserInput = "";
        int currentTemperature = 32;
        int textSpeedSetting = 3;

        public Form2()
        {
            InitializeComponent();
            InputConsole1.Visible = false;
            ConvertButton.Visible = false;
            TemperatureInput.Visible = false;
            Size = new Size(450, 450);
            isCurrentTaskFinished = false;
            ConsoleConversation(); //"Main" function of form, which is the conversation with the output console.
            isCurrentTaskFinished = true;

        }

        private async Task outputToConsole(string currentMessage) //Method that creates a typewriter effect on the text, with async 
        {
            int textSpeedDelayTime = (150 / textSpeedSetting);
            string currentStackOfChars = "";
            for (int i = 0; i < currentMessage.Length; i++)
            {
                currentStackOfChars = currentStackOfChars + (currentMessage[i]);
                OutputConsole1.Text = currentStackOfChars;
                await Task.Delay(textSpeedDelayTime);
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
            ConvertButton.Visible = true;
            TemperatureInput.Visible = true;
            trackBar1.Visible = true;
        }

        private void InputConsole1_Click(object sender, EventArgs e) //Clicking the first program button
        {
            if (isCurrentTaskFinished == true)
            {
                isCurrentTaskFinished = false;
                Program1();

            }
        }

        private async Task Program1() //currently worked on C# Task from microsoft
        {

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
                isCurrentTaskFinished = true;
            }
        }

        private void GardenToolsKill_Click(object sender, EventArgs e) //Close the program
        {
            this.Close();
        }

        private void ConvertButton_Click(object sender, EventArgs e) //launches converter method
        {
            if (isCurrentTaskFinished == true) //check that another task isnt running at the same time.
            {
                isCurrentTaskFinished = false;
                ConverterProgram();

            }
        }

        private async Task ConverterProgram() //converts temperature into Fahrenheit 
        //doesn't need false/true settings because method is wrapped around them.
        {
            try //try to parse int number from text box and throw an exception if it can't
            {

                currentTemperature = Int32.Parse(TemperatureInput.Text);
                await outputToConsole($"Converting {currentTemperature} into celcius...");
                decimal fahrenheit = (decimal)currentTemperature;

                fahrenheit = fahrenheit - 32m;
                decimal celcius = fahrenheit * (5m / 9m);
                string roundedCelcius = celcius.ToString("0.00");
                await outputToConsole($"{currentTemperature}°F in celcius is {roundedCelcius}°C!");
            }
            catch (Exception)
            {
                await outputToConsole("That's not a number...");
            }
            isCurrentTaskFinished = true;
        }

        private void trackBar1_OnScroll(object sender, EventArgs e)
        {
            isCurrentTaskFinished = false;
            textSpeedSetting = trackBar1.Value;
            string trackBarMessage = $"Text Speed: {textSpeedSetting.ToString()}";
            outputToConsole(trackBarMessage);
            isCurrentTaskFinished = true;
        }
    }
}
