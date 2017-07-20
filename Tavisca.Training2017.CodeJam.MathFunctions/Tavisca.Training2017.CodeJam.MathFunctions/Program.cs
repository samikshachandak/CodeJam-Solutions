using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            double number,result;
            TrignometricFunctions trignometricFunctions = new TrignometricFunctions();
            NumberFunctions numberFunctions = new NumberFunctions();

            Console.WriteLine("Enter the number :");
            number = Convert.ToDouble(Console.ReadLine());

            result = trignometricFunctions.FindCosAngle(number);
            Console.WriteLine("Cosine Angle :{0} ",result);
            result = trignometricFunctions.FindSinAngle(number);
            Console.WriteLine("Sin Angle :{0} ", result);
            result = trignometricFunctions.FindTanAngle(number);
            Console.WriteLine("Tan Angle :{0} ", result);

            result = numberFunctions.CalculateSqrt(number);
            Console.WriteLine("Square Root of Number is :{0} ", result);
            result = numberFunctions.CalculateLog(number);
            Console.WriteLine("Log of Number is :{0} ", result);
            Console.ReadKey();
        }
    }
}
