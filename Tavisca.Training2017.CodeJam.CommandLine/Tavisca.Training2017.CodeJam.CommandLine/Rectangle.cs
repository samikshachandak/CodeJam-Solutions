using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.CommandLine
{
    public class Rectangle
    {
        public void CalculateArea(double length, double width)
        {
            Console.WriteLine("Area Of Rectangle :{0}", (length * width));
        }


        public void CalculatePerimiter(double length, double width)
        {
            Console.WriteLine("Perimeter Of Rectangle :{0}", (2 * (length+width)));
        }
    }
}
