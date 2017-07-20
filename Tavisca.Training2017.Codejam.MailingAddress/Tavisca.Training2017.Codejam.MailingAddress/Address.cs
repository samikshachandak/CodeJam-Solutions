using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.Codejam.MailingAddress
{
    class Address
    {

        private string nameOfPerson;
        private string city;
        private string street;
        private int pincode;
        private int houseNumber;

        public string Name
        {
            get { return nameOfPerson; }
            set { nameOfPerson = value; }
        }

        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }

        public int HouseNumber
        {
            get { return houseNumber; }
            set { houseNumber = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string GetAddress()
        {
            string completeAddress = "\n" + Name + " \n" + HouseNumber + " \n" + Street + " \n" + City + "\n" + Pincode;
            return completeAddress;
        }
    }
}

