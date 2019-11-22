using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstPointlessGame
{
    static class StartGame
    {
        internal static void AreYouReady()
        {
            StartingText();
            string input;
            do
            {
                Console.Write("Are you ready to play? (y/n) ");
                input = Console.ReadLine();
                if (input == "n")
                {
                    StopGame.TheEndHasArrived();
                }

            } while (input != "y" && input != "n");
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
        }       
        private static void StartingText() => 
            Console.WriteLine
            ("Just a pointless game!\n\n\t" +
                "In this game you can only move your character by pressing the arrow buttons.\n\n\t" +
                "By pressing any other key your player will change from '*' to the pressed character.\n\n\t" +
                "Press the 'ESC' button at any time to exit the game!\n");
    }
}
