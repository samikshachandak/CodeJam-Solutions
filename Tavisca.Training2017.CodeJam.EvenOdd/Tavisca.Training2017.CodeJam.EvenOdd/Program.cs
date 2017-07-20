using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber;
            inputNumber = Console.ReadLine();
            long input;
            CheckString checkString = new CheckString();
            EvenOdd evenOdd = new EvenOdd();
            bool isNumber = checkString.IsDigits(inputNumber);
            if (isNumber)
                input = Convert.ToInt64(inputNumber);
            else
                input = 0;
           
            evenOdd.IsEven(input);
 
        }
    }
}
