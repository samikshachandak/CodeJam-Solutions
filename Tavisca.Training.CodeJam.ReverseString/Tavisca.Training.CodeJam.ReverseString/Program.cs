using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training.CodeJam.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            input=Console.ReadLine();

            ReverseString reverseString = new ReverseString();
            input = reverseString.ReverseTheString(input);
            Console.WriteLine(input);
            Console.ReadKey();
        }

    }
}
