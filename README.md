# GardenForms
Garden forms is currently my WIP template for learning .NET 4 and C#.
It's a modular "app launcher" (if you could dare to call it that) which launches different mini programs I've developed in C#.
They're all fairly simple and are just a way for me to learn some of the basic functions of C#.
Right now the mini programs included are as follows:

# FeedMe
-This program launches a window where you can click to "feed" the program, increasing its "fullness" bar over time.
-After feeding it too much it will become annoyed and start shaking before it "pops".

# Toolbox
-This program let me practice with async methods, such as a typewriter effect output console.
-Async methods will be very useful in the future for developing APIs as most of the methods are async
-Currently there is one function, to generate two random numbers and test if they are divisible, but the point is more that the output will be displayed in the console window with a typewriter effect.
-The async of the console output means that the main thread doesn't pause the frame loading of the gif background while it delays between outputting each letter of the result.
