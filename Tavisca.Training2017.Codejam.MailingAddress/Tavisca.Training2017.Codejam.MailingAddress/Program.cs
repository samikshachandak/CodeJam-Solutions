using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Codejam.MailingAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            input.GetInput();
            input.Display();
            Console.ReadKey();
        }
    }
}
