using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Traing2017.CodeJam.CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = new int[10];
            int[] copiedArray = new int[10];
            Console.WriteLine("Enter Input for Array");
            for (int i = 0; i < 10; i++)
            {
                initialArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("After Copying");
            for (int j = 0; j < 10; j++)
            {
                copiedArray[j] = initialArray[j];

                Console.WriteLine(copiedArray[j]);
            }
            Console.ReadKey();
        }
    }
}
