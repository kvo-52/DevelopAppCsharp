using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_05_Calculater
{
    internal class Program
    {
        static void Main()

        {

            string action = "";

            do
            {

                {

                    Console.WriteLine("Выберите действие: +, -, *, /, q (для выхода)");

                    action = Console.ReadLine();



                    if (action == "+" || action == "-" || action == "*" || action == "/")

                    {

                        Console.WriteLine("Введите первое число:");

                        double num1 = Convert.ToDouble(Console.ReadLine());



                        Console.WriteLine("Введите второе число:");

                        double num2 = Convert.ToDouble(Console.ReadLine());



                        double result = 0;



                        switch (action)

                        {

                            case "+":

                                result = num1 + num2;

                                break;

                            case "-":

                                result = num1 - num2;

                                break;

                            case "*":

                                result = num1 * num2;

                                break;

                            case "/":

                                result = num1 / num2;

                                break;

                            default:

                                Console.WriteLine("Некорректное действие!");

                                break;

                        }



                        Console.WriteLine("Результат: " + result);

                    }

                    else if (action != "q" && action != "")

                    {

                        Console.WriteLine("Некорректное действие!");

                    }
                }

            } while (action != "q" && action != "");
            Console.WriteLine("Программа завершена");
        }
    }

}