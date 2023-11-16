using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_06_Exeption
{
    public class CalculatorDivideByZeroException : CalcExeption
    {
        public CalculatorDivideByZeroException()
        {

        }
        public CalculatorDivideByZeroException(string error) : base(error)
        {

        }

    }
}
