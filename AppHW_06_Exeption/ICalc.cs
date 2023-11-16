using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_06_Exeption
{
    internal interface ICalc
    {
        double Result  { get; set; }
        void Sum(double x, double y);
        void Sub(double x, double y);
        void Multy(double x, double y);
        void Divide(double x, double y);
        void CancleLast();

        event EventHandler<EventArgs> MyEventHandler;
    }
}
