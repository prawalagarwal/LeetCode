using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {-1, -2, -3, -4, -5};
            var sol = TwoSum(nums, -8);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numset = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numset.ContainsKey(complement) && numset[complement] != i)
                {
                    return new int[] { numset[complement], i };
                }

                numset[nums[i]] =  i;
            }

            return null;
        }
    }
}
