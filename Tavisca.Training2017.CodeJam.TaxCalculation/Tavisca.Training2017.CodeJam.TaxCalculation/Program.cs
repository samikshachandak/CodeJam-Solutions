using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double income;
            double tax;
            Console.WriteLine("Enter the Income :");
            income = Convert.ToDouble(Console.ReadLine());
            if (income < 10000)
            {
                tax = income * 5 / 100;
            }
            else if (income < 100000)
            {
                tax = 500 + (income * 8 / 100);
            }
            else
            {
                tax = 8500 + (income * 8.5 / 100);
            }
            Console.WriteLine("Tax to be paid :{0}", tax);
            Console.ReadKey();
        }
    }
}
