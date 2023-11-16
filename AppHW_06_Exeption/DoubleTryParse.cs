using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW_06_Exeption
{
    public class DoubleTryPars
    {

        public double DoubleTryParse(string input)
        {

            try
            {
                double result = double.Parse(input);
                if (result >= 0)
                {
                    return result;

                }
                else
                {
                    Console.WriteLine("Число отрицательное");
                    result = 0;
                    return result;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите число!");
                return 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
