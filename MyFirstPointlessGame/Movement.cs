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
                    Move_Left(ref _left);
                    break;
                case ConsoleKey.RightArrow:
                    Move_Right(ref _left);
                    break;
                case ConsoleKey.UpArrow:
                    Move_Up(ref _top);
                    break;
                case ConsoleKey.DownArrow:
                    Move_Down(ref _top);                    
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
        private static void Move_Up(ref int position) => position = position == 0 ? Console.BufferHeight - 1 : --position;           
        private static void Move_Left(ref int position) => position = position == 0 ? Console.BufferWidth - 1 : --position;        
        private static void Move_Down(ref int position) => position = position == Console.BufferHeight - 1 ? 0 : ++position;       
        private static void Move_Right(ref int position) => position = position == Console.BufferWidth - 1 ? 0 : ++position;      
    }    
}
