using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp
{
    public static class TwoSum
    {
        public static int[] Method1(int[] nums, int target) 
        {
            for (int i = 0; i<nums.Length; i++) {
                for(int j=i+1; j<nums.Length; j++) {
                    if (target - nums[j] == nums[i])
                    {
                        return new int[] {i,j};
                    }
                }
            }
            throw new Exception();
        }

        public static int[] Method2(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i=0; i<nums.Length; i++)
            {
                dictionary[i] = nums[i];
            }

            for (int i = 0; i<nums.Length; i++)
            {
                var compareNumber = target - nums[i];

                if(dictionary.ContainsValue(compareNumber))
                {
                    return new int[] { i, dictionary.FirstOrDefault(x => x.Value == compareNumber).Key};
                }
            }
            throw new Exception("Not available");
        }

        public static int[] Method3(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i=0; i<nums.Length; i++)
            {
                var compareNumber = target - nums[i];
                if(dictionary.ContainsValue(compareNumber))
                {
                     return new int[] { i, dictionary.FirstOrDefault(x => x.Value == compareNumber).Key};
                }
                dictionary[i] = nums[i];
            }
            throw new Exception("Not available");
        }
    }
}
