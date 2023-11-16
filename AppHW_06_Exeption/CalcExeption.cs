using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_06_Exeption
{
    public class CalcExeption: Exception
    {
        public CalcExeption()
        {

        }
        public CalcExeption(string error) : base(error)
        {

        }

    }
}
