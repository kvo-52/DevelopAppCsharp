using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_06_Exeption
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DoubleTryPars doubleTryPars=new DoubleTryPars();
            bool exit = true;

            while (exit)
            {
            var calc = new CalcLogic();
            calc.MyEventHandler += Calc_MyEventHandler;

                Console.WriteLine("Enter first number");
                double number1 = doubleTryPars.DoubleTryParse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                double number2 = doubleTryPars.DoubleTryParse(Console.ReadLine());
                Console.WriteLine("Select an action \n1. + \n2. - \n3. / \n4. *");
                
                int symbol = Convert.ToInt32(Console.ReadLine());

                switch (symbol)
                {
                    case 1: calc.Sum(number1, number2); break;
                    case 2:
                        try
                        {
                            calc.Sub(number1, number2);
                        }
                        catch (CalcExeption ex)
                        {
                            Console.WriteLine(" Результат отрицательный! Введите второе число больше первого!");
                        }
                        
                         break;
                        
                                

                    case 3:

                        try
                        {
                            calc.Divide(number1, number2);
                        }

                        catch (CalculatorDivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        catch (CalcExeption ex)
                        {
                            Console.WriteLine(ex);
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                        break;

                    case 4: calc.Multy(number1, number2); break;


                }
                Console.WriteLine("Continue ?");
                Console.WriteLine("Press F to finish");

                if (Console.ReadKey().Key == ConsoleKey.F)
                {
                    exit = false;
                }
                Console.Clear();
            }


        }

         
        private static void Calc_MyEventHandler(object? sender, EventArgs e)
        {
            if (sender is CalcLogic)
                Console.WriteLine(((CalcLogic)sender).Result);
        }
    }

}

