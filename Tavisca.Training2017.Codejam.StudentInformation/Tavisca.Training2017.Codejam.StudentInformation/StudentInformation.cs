using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Codejam.StudentInformation
{
    class StudentInformation
    {
        private string nameOfPerson;
        private int rollNumber;
        private int age;
        private string classDetails;
        private string universityDetails;
        

        public string Name
        {
            get { return nameOfPerson; }
            set { nameOfPerson = value; }
        }

        public int RollNumber
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

       

        public string ClassDetails
        {
            get { return classDetails; }
            set { classDetails = value; }
        }
        public string UniversityDetails
        {
            get { return universityDetails; }
            set { universityDetails = value; }
        }

        public string GetInformation()
        {
            string completeAddress = "\n" + Name + " \n" + RollNumber + " \n" + Age + " \n" + ClassDetails + "\n" + UniversityDetails;
            return completeAddress;
        }
    }
}


