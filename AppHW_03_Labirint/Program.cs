﻿using AppLabirint;
namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new ProgramLabirint().HasExit(1, 1));

            Console.WriteLine("Количество выходов: " + new ProgramLabirintColExit().CountHasExit(1, 1));
        }
    }
}