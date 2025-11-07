using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn.AlgoTmp
{
    class AlgoQ3_ValidParentheses
    {
        public AlgoQ3_ValidParentheses()
        {


            bool cevap1 = IsValid_Solution("({[])()}");
            bool cevap = IsValid("([](){)}");
        }


        private bool IsValid_Solution(string strVal) {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> mapping = new Dictionary<char, char>() {
                {')','(' },
                {']','[' },
                {'}','{' },
            };


            foreach (char c in strVal) {

                if (mapping.ContainsKey(c)) // bu kapamami 
                {
                    //varsa , valu yu al ve stack deki son kayit ile ayni mi bak degilse hata 
                    char top = (stack.Count > 0 ? stack.Pop() : '#');
                    if (top != mapping[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            
            }

            return (stack.Count==0);
        }



        private bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> mapping = new Dictionary<char, char>  {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }};

            foreach (char c in s)
            {
                if (mapping.ContainsKey(c)) // Kapama parantezi ise
                {
                    char top = stack.Count > 0 ? stack.Pop() : '#';
                    if (top != mapping[c])
                    {
                        return false;
                    }
                }
                else // Açma parantezi ise stack'e ekle
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }



    }
}
