using Recursive;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabirint
{


    internal class ProgramLabirintColExit
    {

        int[,] l = new int[,]
        {
        {1, 2, 1, 1, 1, 1, 1 },
        {1, 0, 0, 0, 0, 0, 1 },
        {1, 0, 1, 0, 1, 0, 1 },
        {0, 0, 0, 0, 1, 0, 2 },
        {1, 1, 0, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 },
        {1, 1, 1, 0, 2, 1, 1 }
        };

        int countExit = 0;

        public int CountHasExit(int startI, int startJ)
        {

            if (l[startI, startJ] == 1)
            {
                Console.WriteLine("Начальная точка находится в стене!");
                return 0;
            }


            else if (l[startI, startJ] == 2)
            {
                Console.WriteLine("Выход там же где и вход!");
                return 1;
            }

            var stack = new Stack<Tuple<int, int>>();
            stack.Push(new(startI, startJ));

            int[] dx = { 0, 0, -1, 1 };
            int[] dy = { -1, 1, 0, 0 };

            while (stack.Count > 0)
            {
                var temp = stack.Pop();

                while (stack.Count > 0)
                {
                    var temp = stack.Pop();

                    if (l[temp.Item1, temp.Item2] == 2)
                    {
                        countExit++;
                        Console.WriteLine($"Выход найден! - тут: [{temp.Item1} - {temp.Item2}]");
                    }

                    l[temp.Item1, temp.Item2] = 1;

                    for (int i = 0; i < 4; i++)
                    {
                        int newX = temp.Item1 + dx[i];
                        int newY = temp.Item2 + dy[i];

                        if (newX >= 0 && newX < l.GetLength(0) && newY >= 0 && newY < l.GetLength(1) && l[newX, newY] != 1)
                        {
                            stack.Push(new Tuple<int, int>(newX, newY));
                        }
                    }
                }

                return countExit;
            }

            
        }

    }
}
        