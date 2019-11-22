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
                    if (_left == 0)
                    {
                        _left = Console.BufferWidth - 1;
                        break;
                    }
                    _left--;
                    break;
                case ConsoleKey.RightArrow:
                    if (_left == Console.BufferWidth - 1)
                    {
                        _left = 0;
                        break;
                    }
                    _left++;
                    break;
                case ConsoleKey.UpArrow:
                    if (_top == 0)
                    {
                        _top = Console.BufferHeight - 1;
                        break;
                    }
                    _top--;
                    break;
                case ConsoleKey.DownArrow:
                    if (_top == Console.BufferHeight -1)
                    {
                        _top = 0;
                        break;
                    }
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
