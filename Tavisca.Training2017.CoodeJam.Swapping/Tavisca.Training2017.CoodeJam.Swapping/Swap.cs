using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CoodeJam.Swapping
{
    class Swap
    {
        public void DoSwapping(double number1,double number2)
        {
            Console.WriteLine("After Swapping :");
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Number 1:{0},Number 2 :{1}",number1,number2);
            Console.ReadKey();
        }

    }
}
