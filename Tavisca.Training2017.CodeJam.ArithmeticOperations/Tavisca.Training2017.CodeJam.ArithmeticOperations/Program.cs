using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, number4,result=0;

            Console.WriteLine("Enter value for number 1:");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for number 2:");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for number 3:");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for number 4:");
            number4 = Convert.ToDouble(Console.ReadLine());

            ArithmeticCalculations arithmeticCalculations = new ArithmeticCalculations();
            arithmeticCalculations.Addition(number1,number2,number3, number4,out result);
            Console.WriteLine("Addition is :{0}",result);
            arithmeticCalculations.Subtraction(number1, number2, number3, number4, out result);
            Console.WriteLine(" Subtraction is :{0}", result);
            arithmeticCalculations.Multiplication(number1, number2, number3, number4, out result);
            Console.WriteLine("Multiplication is :{0}", result);
           
            Console.ReadKey();
        }
    }
}
