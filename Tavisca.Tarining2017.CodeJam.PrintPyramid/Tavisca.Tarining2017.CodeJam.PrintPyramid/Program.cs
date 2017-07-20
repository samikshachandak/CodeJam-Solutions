using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Tarining2017.CodeJam.PrintPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int tab, numberForManipulation, row;
            for (row = 1; row <= 5; row++)
            {
                for (tab = 1; tab <= (5 - row); tab++)
                {
                    Console.Write(" ");
                }
                for (numberForManipulation = 1; numberForManipulation <= row; numberForManipulation++)
                {
                    Console.Write(numberForManipulation);
                }
                for (numberForManipulation = (row - 1); numberForManipulation >= 1; numberForManipulation--)
                {
                    Console.Write(numberForManipulation);
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
