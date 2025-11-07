using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn.AlgoTmp
{
    class AlgoQ4_ReverseString
    {
        public AlgoQ4_ReverseString()
        {
            var ttt = ReverseString_S1("Bahadir");
        }

        private string ReverseString_S1(string str) {
            char[] chrArry = str.ToCharArray();
            Array.Reverse(chrArry);

            string retVal = new String(chrArry);
            return "";
        }
    }
}