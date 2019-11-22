using System;

namespace MyFirstPointlessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int _left = 0;
            int _top = 0;
            char player = '*';
            StartGame.AreYouReady();
            while (true)
            {
                ConsoleScreen.RefreshScreen(_left, _top, player);
                Console.SetCursorPosition(_left, _top);
                Movement.AcceptInput(ref _left, ref _top, ref player);
            }
        }
    }
}
