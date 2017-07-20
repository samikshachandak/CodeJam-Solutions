using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.EvenOdd
{
    class EvenOdd
    {
        public void IsEven(long inputNumber)
        {
            if (inputNumber == 0)
            {
                Console.WriteLine("Invalid Input");   
            }
            if (inputNumber > 0 && inputNumber % 2 == 0)
                Console.WriteLine("Number {0} is Even", inputNumber);
            else
            if (inputNumber > 0)
            {
                Console.WriteLine("Number {0} is Odd", inputNumber);
            }
                Console.ReadKey();
        }
    }
}
