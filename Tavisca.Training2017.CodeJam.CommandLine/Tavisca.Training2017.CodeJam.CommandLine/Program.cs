using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string length=args[0];
            string width=args[1];

            CheckString checkString = new CheckString();
            Rectangle rectangle = new Rectangle();
            bool checkedLength = checkString.IsDigits(length);
            bool checkedWidth = checkString.IsDigits(width);

            double lengthToBePassed = Convert.ToDouble(args[0]);
            double widthToBePassed = Convert.ToDouble(args[1]);

            if (checkedLength && checkedWidth)
            {
                rectangle.CalculateArea(lengthToBePassed, widthToBePassed);
                rectangle.CalculatePerimiter(lengthToBePassed, widthToBePassed);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        }
    }
}
