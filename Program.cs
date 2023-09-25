using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

class Program
{
    // Import the necessary functions from user32.dll to control the mouse
    [DllImport("user32.dll")]
    private static extern bool SetCursorPos(int x, int y);

    static void Main(string[] args)
    {
        // Define the screen boundaries (you may need to adjust these based on your screen resolution)
        int screenWidth = 1920; // Change to your screen width
        int screenHeight = 1080; // Change to your screen height

        Random random = new Random();

        while (true)
        {
            // Wait for 5 seconds
            Thread.Sleep(5000);

            // Get random coordinates within the screen boundaries
            int randomX = random.Next(screenWidth);
            int randomY = random.Next(screenHeight);

            // Move the mouse to the random position
            SetCursorPos(randomX, randomY);

            // Wait for 2 seconds
            Thread.Sleep(2000);
        }
    }
}




