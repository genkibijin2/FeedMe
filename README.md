# GardenForms
Garden forms is currently my WIP template for learning .NET 4 and C#. <br />
It's a modular "app launcher" (if you could dare to call it that) which launches different mini programs I've developed in C#.  <br />
They're all fairly simple and are just a way for me to learn some of the basic functions of C#. <br />
Right now the mini programs included are as follows: <br />

# FeedMe
This program launches a window where you can click to "feed" the program, increasing its "fullness" bar over time.<br />
After feeding it too much it will become annoyed and start shaking before it "pops".<br />


# Toolbox
This program let me practice with async methods, such as a typewriter effect output console.<br />
Async methods will be very useful in the future for developing APIs as most of the methods are async.<br />
Currently there is one function, to generate two random numbers and test if they are divisible, but the point is more that the output will be displayed in the console window with a typewriter effect.<br />
The async of the console output means that the main thread doesn't pause the frame loading of the gif background while it delays between outputting each letter of the result.<br />
<br /><br />
![GardenFormsScreenshot1](https://github.com/user-attachments/assets/a8408afd-9f94-4ca0-8541-03d5f804602e)


# Mahjong Tile dice
This program lets me test out async random numbers and simulate a dice roll environment. It also allowed me to try making custom frames without system titlebars etc, and then giving it code to function as a window should.<br />
![GardenFormsScreenshot2](https://github.com/user-attachments/assets/5bb90df0-7bda-4584-94ab-64bc5f2d52bc)

# VMU
This app is testing a few different features. The first is creating non-standard winforms shapes using the transparency layers and some custom bitmaps. It's mainly a test for the Graphics() methods, and the OnPaint event that exists inside winforms. There are sliders that control the values fed into the rectangles drawn on every frame, and a colour button that alters the type of gradient used. <br /><br />
![GardenFormsScreenshot3](https://github.com/user-attachments/assets/27cf70e4-01a3-4daa-9f60-673e9f1137b2)

/---The program is designed to be run on windows x64, but includes all of the dependencies inside of the single .exe file in order to make it ultra-portable.---\<br />
\--------The massive filesize is because all of the .net dependencies that usually need to be downloaded from microsoft are packaged inside of the .exe---------/<br />
