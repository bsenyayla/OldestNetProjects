using AppLearn.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn.AlgorithmExamples
{
    public class Palindrome : SamplePatternClass
    {
        public Palindrome(TextBox refText) : base(refText)
        {
            MsgTT("“Write a method to check if a string is a palindrome.”");
        }


        public void Way1(String str) {
            str = str.Trim().ToLower();
            String reverse = new String(str.Reverse().ToArray());

            if (str == reverse)
            {
                MsgTT("Palindrome..");
            }
            else
            {
                MsgTT("Palindrome.. degil");
            }
        }



        public void Way2(String str) {

            MsgTT(Environment.NewLine + 
                "Way 2 Palindrome ");


            str = str.Trim().ToLower();

            char[] reverseArr = str.ToArray();
            Array.Reverse<char>(reverseArr);

            String reverseString = new String(reverseArr);

            if (reverseString == str)
            {
                MsgTT("Palindrome ");
            }
            else {
                MsgTT("Palindrome Degil");
            }
        }


        public void Way3_WithStack(String str)
        {
            MsgTT(Environment.NewLine +
                "Way 3 Palindrome - Solution With Stack");


            str = str.Trim().ToLower();


            Stack<char> stcStr = new Stack<char>();

            foreach(char chr in str)
            {
                stcStr.Push(chr);
            }

            String reverseString = new String(stcStr.ToArray());



            if (reverseString == str)
            {
                MsgTT("Palindrome ");
            }
            else
            {
                MsgTT("Palindrome Degil");
            }
        }






    }
}
