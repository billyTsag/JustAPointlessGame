using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstPointlessGame
{
    static class StartGame
    {
        internal static void AreYouReady(int _left, int _top)
        {
            Console.WriteLine("Just a pointless game!\n\n\tIn this game you can only move your character by pressing the arrow buttons.\n\n\tBy pressing any other key your player will change from '*' to the pressed character.\n");
            Console.WriteLine("\tPress the 'ESC' button at any time to exit the game!\n");
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
            Console.CursorVisible = false;
            Console.SetCursorPosition(_left, _top);
        }        
    }
}
