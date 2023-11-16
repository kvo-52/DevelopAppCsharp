using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_06_Exeption
{
    internal class CalcLogic : ICalc
    {
        public double Result { get; set; } = 0D;

        public event EventHandler<EventArgs> ?MyEventHandler;

        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public void PrintResult() {
            MyEventHandler?.Invoke(this, new EventArgs());
        }
        public void Divide(double x, double y)
        {
            if (y != 0)
            {
             Result=x/y;
            }
            else
            {
                throw new CalculatorDivideByZeroException();
                Console.WriteLine("Error. Divide by null");
            }
            
            PrintResult();
            LastResult.Push(Result);

        }

        public void Multy(double x, double y)
        {
            Result=x*y;
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sub(double x, double y)
        {
            if (x < y)
            {
                throw new CalculatorDivideByZeroException();
                Console.WriteLine("Error. Sub by null");
            }
            else
            {
            Result =x-y;
            PrintResult();  
            }
                        
            LastResult.Push(Result);
        }

        public void Sum(double x, double y)
        {
            Result =x+y;
            PrintResult();
            LastResult.Push(Result);

        }

        public void CancleLast()
        {
           if( LastResult.TryPop(out double res))
            {
                Result = res;
                Console.WriteLine("Последнее действие отменено. Результат =");
                PrintResult();
            }
            else
            {
                Console.WriteLine("Невозможно отменить последнее действие.");
            }

        }


    }
}
