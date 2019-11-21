using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstPointlessGame
{
    static class ConsoleScreen
    {
        internal static void RefreshScreen(int _left, int _top, char player)
        {
            Console.Clear();
            Console.SetCursorPosition(_left,_top);
            Console.Write(player);
        }
    }
}
