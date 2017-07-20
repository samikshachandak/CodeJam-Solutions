using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.PowerOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, powerDigit;
            Console.WriteLine("Enter the Number : ");
            number = double.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Power of Zero Could not be calculated");
            }
            else
            {
                Console.WriteLine("Enter the Power: ");
                powerDigit = double.Parse(Console.ReadLine());
                double result = Math.Pow(number, powerDigit);
                Console.WriteLine("Result : {0}", result);
            }
                Console.ReadLine();
        }
    }
}
