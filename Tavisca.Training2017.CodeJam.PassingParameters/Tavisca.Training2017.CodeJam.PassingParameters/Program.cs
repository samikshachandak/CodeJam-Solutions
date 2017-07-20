using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.PassingParameters
{
    class Program
    {
        static void ModifyNumberUsingValueType(int number)
        {
            number =50;
            Console.WriteLine("Value of number in function :{0}",number);
        }

        static void Main(string[] args)
        {
            int number = 1;

            Console.WriteLine(number);

            ModifyNumberUsingValueType(number);
            Console.WriteLine("Value after passing variable as value type :{0}",number);

            ModifyNumberUsingReferenceType(ref number);
            Console.WriteLine("Value after passing variable as reference type :{0}", number);
            Console.ReadKey();
        }

        private static void ModifyNumberUsingReferenceType(ref int number)
        {
            number = 50;
            Console.WriteLine("Value of number in function:{ 0}",number);
        }
    }
}
