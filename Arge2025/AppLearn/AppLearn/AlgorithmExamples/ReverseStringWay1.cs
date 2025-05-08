using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppLearn.Common.Tools;

namespace AppLearn.AlgorithmExamples
{
    public class ReverseStringWay1
    {
        private TextBox _refTextBox;
        public ReverseStringWay1(TextBox refText)
        {
            _refTextBox = refText;
            Msg(_refTextBox, "Reverse String Way 1: With ReverseToCharArray");
        }

        public string ReverseString(String str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            Msg(_refTextBox, @"Input:" + str + " - Output:" + new string(charArray));

            return new string(charArray);
        }

        public string ReverseStringWithFor(String str) {
            Msg(_refTextBox, "Reverse String Way 1: With For");

            string retVal = "";
            for(int i = str.Length; i > 0; i--)
            {
                retVal += str[i-1];
            }

            Msg(_refTextBox, @"Input:" + str + " - Output:" + retVal);
            return retVal;
        }



        public string StringSort(String str)
        {
            Msg(_refTextBox, "String Sort ArraySort");

            char[] charStr = str.ToCharArray();
            Array.Sort(charStr);


            Msg(_refTextBox, @"Input:" + str + " - Output:" + new string(charStr));
            return "";
        }



    }
}