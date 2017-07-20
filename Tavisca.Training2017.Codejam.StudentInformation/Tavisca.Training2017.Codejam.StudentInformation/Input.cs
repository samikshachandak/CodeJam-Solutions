using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Codejam.StudentInformation
{
    class Input
    {

        StudentInformation studentInformation;
        public Input()
        {
           studentInformation = new StudentInformation();
        }

        public void GetInput()
        {
            Console.WriteLine("Name: ");
            studentInformation.Name = Console.ReadLine();

            Console.WriteLine("Roll Num: ");
            studentInformation.RollNumber = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Age: ");
            studentInformation.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Class: ");
            studentInformation.ClassDetails = Console.ReadLine();

            Console.WriteLine("University Name: "); 
            studentInformation.UniversityDetails = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Student Details ");
            Console.WriteLine(studentInformation.GetInformation());

        }
    }
}



