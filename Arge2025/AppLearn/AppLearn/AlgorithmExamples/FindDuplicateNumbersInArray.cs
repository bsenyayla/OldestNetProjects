using AppLearn.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn.AlgorithmExamples
{
    public class FindDuplicateNumbersInArray : SamplePatternClass
    {
        public FindDuplicateNumbersInArray(TextBox refText) : base(refText)
        {
            MsgTT("Find duplicate numbers in an array");
        }

        public void Way1_Linq(int[] numbers)
        {
            MsgTT("Solution with Linq");
            MsgTT("Input:" + string.Join(", ", numbers));

            int[] result = numbers
                .GroupBy(n => n)
                .Where(n => n.Count() > 1)
                .Select(x => x.Key).ToArray();

            MsgTT("Output:" + string.Join(", ", result));
        }

        public void Way2_HashTable(int[] numbers)
        {
            MsgTT("Solution with Hashtable");
            MsgTT("Input:" + string.Join(", ", numbers));

            HashSet<int> htAll = new HashSet<int>();
            HashSet<int> htResult = new HashSet<int>();

            for (int i = 0; i < numbers.Length ; i++) {
                if (!htAll.Add(numbers[i])) {
                    htResult.Add(numbers[i]);
                }
            }

            MsgTT("Result " + string.Join(", ", htResult.ToArray()));
        }


        public void Way3_OnO1(int[] arr)
        {
            MsgTT(Environment.NewLine + "===================================================================================================");
            MsgTT("Solution 3 - On -O1 ");
            MsgTT("Input:" + string.Join(", ", arr));

            for (int i = 0; i < arr.Length; i++)
            {
                int index = Math.Abs(arr[i]);
                if (arr[index] >= 0)
                {
                    arr[index] = -arr[index];
                }
                else
                {
                    Console.WriteLine("Duplicate: " + index);
                }
                    
            }
        }

    }
}