using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Codejam.MailingAddress
{
    class Input
    {
        Address address;
        public Input()
        {
            address = new Address();
        }

        public void GetInput()
        {
            Console.WriteLine("Name: ");
            address.Name = Console.ReadLine();

            Console.WriteLine("City: ");
            address.City = Console.ReadLine();

            Console.WriteLine("Street: ");
            address.Street = Console.ReadLine();

            Console.WriteLine("House Number: ");
            address.HouseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Pin: ");
            address.Pincode = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Mail Address is ");
            Console.WriteLine(address.GetAddress());

        }
    }
}

