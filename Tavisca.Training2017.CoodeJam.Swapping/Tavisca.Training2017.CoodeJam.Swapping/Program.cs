using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CoodeJam.Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            number1 = Convert.ToDouble(Console.ReadLine());
            number2 = Convert.ToDouble(Console.ReadLine());
            Swap swap = new Swap();
            swap.DoSwapping(number1,number2);
            
        }
    }
}
