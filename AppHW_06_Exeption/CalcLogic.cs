using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_05_Calculater
{
    internal class CalcLogic : ICalc
    {
        public double Result { get; set; } = 0D;

        public event EventHandler<EventArgs> ?MyEventHandler;

        private Stack<double> LastResult { get; set; } = new Stack<double>();

        public void PrintResult() {
            MyEventHandler?.Invoke(this, new EventArgs());
        }
        public void Divide(int x)
        {
            Result/=x;
            PrintResult();
            LastResult.Push(Result);

        }

        public void Multy(int x)
        {
            Result*=x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sub(int x)
        {
            Result -=x;
            PrintResult();
            LastResult.Push(Result);
        }

        public void Sum(int x)
        {
            Result += x;
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
