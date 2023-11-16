using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_05_Calculater
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calc = new CalcLogic();
            calc.MyEventHandler += Calc_MyEventHandler;


            

            //calc.Multy(4);
            //calc.Sub(12);
            //calc.Divide(2);
            //calc.Sum(9);


        }

        private static void Calc_MyEventHandler(object? sender, EventArgs e)
        {
            if (sender is CalcLogic)
                Console.WriteLine(((CalcLogic)sender).Result);
        }
    }

}

