using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn.AlgoTmp
{
    class AlgoQ2_TwoSum
    {
        public AlgoQ2_TwoSum()
        {


        //Input: nums = [3, 2, 4], target = 6

                int[] nums = [3, 2, 4];
                int target = 6;

            var retval = SolveTwoSum_WithDictionary(nums, target);
             retval = SolveTwoSum_Question(nums,target);


        }


        //Bu benim buldugum yol ve iyi gorunuyor. for ve indexof ile
        public int[]? SolveTwoSum_Question(int[] nums, int target)
        {
            if (nums.Length == 0) return null;

            for (int startIndex = 0; startIndex < nums.Length-1; startIndex++) {

                int kalan = target - nums[startIndex];

                int index = Array.IndexOf(nums, kalan, startIndex);

                if (index > 0) {
                    return new int[] { startIndex, index };
                }
            }
            return new int[] { 0,0};
        }


        // Cozum dictionary ile
        public int[]? SolveTwoSum_WithDictionary(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i=0; i < nums.Length ; i++) {

                int left = target - nums[i];

                if (dic.ContainsKey(left))
                {
                    return new int[] { dic[left], i };
                }
                else
                {
                    dic.Add(nums[i], i);
                    continue;
                }
            }
            return null;
        }







    }
}
