using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Training2017.CodeJam.EvenOdd
{
    public class CheckString
    {
        public bool IsDigits(string s)
        {
            if (s == null || s == "")
                return false;

            for (int i = 0; i < s.Length; i++)
                if ((s[i] ^ '0') > 9)
                    return false;

            return true;
        }
    }
}
