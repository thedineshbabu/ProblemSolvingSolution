using System.Collections.Generic;

namespace C_Sharp 
{
    public static class yieldSample
    {
        public static IEnumerable<int> GenerateWithoutYield() 
        { 
            var i = 0; 
            var list = new List<int>(); 
            while (i<5) 
                list.Add(++i); 
            return list; 
        } 

        public static IEnumerable<int> GenerateWithYield() 
        { 
            var i = 0; 
            while (i<5) 
                yield return ++i; 
        } 
    }
}