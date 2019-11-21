using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstPointlessGame
{
    static class Movement
    {        
        internal static void AcceptInput(ref int _left, ref int _top, ref char player)
        {
            ConsoleKeyInfo movement = Console.ReadKey();
            switch (movement.Key)
            {
                case ConsoleKey.LeftArrow:
                    _left--;
                    break;
                case ConsoleKey.RightArrow:
                    _left++;
                    break;
                case ConsoleKey.UpArrow:
                    _top--;
                    break;
                case ConsoleKey.DownArrow:
                    _top++;
                    break;
                case ConsoleKey.Spacebar:
                case ConsoleKey.Enter:                
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Escape:
                    StopGame.TheEndHasArrived();
                    break;                    
                default:
                    player = movement.KeyChar;
                    break;
            }            
        }
    }    
}
