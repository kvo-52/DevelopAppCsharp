using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_05_Calculater
{
    internal interface ICalc
    {
        double Result  { get; set; }
        void Sum(int x);
        void Sub(int x);
        void Multy(int x);
        void Divide(int x);
        void CancleLast();

        event EventHandler<EventArgs> MyEventHandler;
    }
}
