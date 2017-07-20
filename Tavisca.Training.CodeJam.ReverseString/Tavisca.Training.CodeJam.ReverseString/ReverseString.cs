using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training.CodeJam.ReverseString
{
    class ReverseString
    {
       public string ReverseTheString(String input)
        {
            char[] inputArray = input.ToCharArray();
            char[] outputArray = new char[input.Length];
            for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
            {
                outputArray[j] = inputArray[i];
            }
            return new string(outputArray);
        }
    }
}
