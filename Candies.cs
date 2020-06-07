using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp
{
    public static class Candies
    {
        public static bool[] Method1(int[] candies, int extracandy)
        {
            bool[] result = new bool[candies.Length];
            var maxCandy = candies.Max();
            for(int i= 0; i<candies.Length; i++)
            {
                result[i] = true ? candies[i] + extracandy >= maxCandy: false;
            }
            return result;
        }

        public static bool[] Method2(int[] candies, int extracandy)
        {
            bool[] result = new bool[candies.Length];
            var maxCandy = candies.Max();
            //var sampl = candies.
            for(int i= 0; i<candies.Length; i++)
            {
                result[i] = true ? candies[i] + extracandy >= maxCandy: false;
            }
            return result;
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
        {
            var maxCandy = candies.Max();
            return candies.Select(s=>s + extraCandies >= maxCandy).ToList();
            // IList<bool> boolResult = new List<bool>();
            // for(int i= 0; i<candies.Length; i++)
            // {
            //     boolResult.Add(true ? candies[i] + extraCandies >= candies.Max(): false);
            // }
            
            // return boolResult;
        }   
    }
}