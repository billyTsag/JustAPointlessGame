using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstPointlessGame
{
    static class StopGame
    {
        internal static void TheEndHasArrived()
        {
            Console.Clear();
            Console.Write("\n\n\t\t\t|Why have you abandonded this masterpiece? :(\n\n");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
