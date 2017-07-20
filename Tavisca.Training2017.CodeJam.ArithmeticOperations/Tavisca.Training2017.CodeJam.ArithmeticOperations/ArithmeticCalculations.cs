using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.ArithmeticOperations
{
    class ArithmeticCalculations
    {
        internal void Addition(double number1, double number2, double number3,double number4, out double result)
        {
            result = number1 + number2 + number3 + number4;
        }

        internal void Subtraction(double number1, double number2,double number3,  double number4, out double result)
        {
            result = number1 - number2 - number3 - number4;
        }

        internal void Multiplication( double number1, double number2,  double number3, double number4,  out double result)
        {
            result = number1 * number2 * number3 * number4;
        }

       
    }
}
