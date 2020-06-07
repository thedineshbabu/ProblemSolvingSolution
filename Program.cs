using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp
{
    class Program
    {
        static int ans;
        static void Main(string[] args)
        {
            // Console.WriteLine("Majority of items in unsorted array");
            // var result = GetMajorityElement(new int[]{1,2,3,4,5,2,2,2,2,9,9,9,9,9,9});
            // Console.WriteLine(result);

            //System.Console.WriteLine("Sum of two numbers");
            //var result = TwoSum.Method1(new int[]{2, 7, 11, 15}, 13);
            //string output = "";
            // foreach(var item in result)
            // {
            //     output = output + item+ ",";
            // }
            // System.Console.WriteLine(output.Trim(','));

            // System.Console.WriteLine("/n");

            // Console.WriteLine("Candies");
            // var candyResult = Candies.Method1(new int[]{2, 3, 5, 1, 3}, 3);
            // foreach(var item in candyResult)
            // {
            //     output = output + item+ ",";
            // }
            // System.Console.WriteLine(output.Trim(','));

            // System.Console.WriteLine("Jewel in Stone");

            // var JewelResult = Jewel.Method3("aA", "aAAbbbb");
            // System.Console.WriteLine(JewelResult);

            // System.Console.WriteLine("Product And Sum");

            // var ProductAndSumResult = ProductAndSum.Method1(234);
            // System.Console.WriteLine(ProductAndSumResult);

            // foreach(var number in yieldSample.GenerateWithoutYield()) 
            // Console.WriteLine(number);

            // foreach(var number in yieldSample.GenerateWithYield()) 
            // Console.WriteLine(number);
            var t = new TreeNode();
            t.left.val = 7;
            t.right.val = 15;
            //t.val.

           // System.Console.WriteLine(rangeSumBST( new TreeNode(){ val = [10,5,15,3,7,null,18], 7, 15));
        }

        public static int rangeSumBST(TreeNode root, int L, int R) 
        {
            ans = 0;
            dfs(root, L, R);
            return ans;
        }

        public static void dfs(TreeNode node, int L, int R) {
        if (node != null) {
            if (L <= node.val && node.val <= R)
                ans += node.val;
            if (L < node.val)
                dfs(node.left, L, R);
            if (node.val < R)
                dfs(node.right, L, R);
        }
    }

        

        

        //Find majority element in an unsorted array
        //Ex. {1,2,3,4,5,2,2,2,2}, 2 is the majority element because it accounts for more than 50% of the array
        public static int GetMajorityElement(params int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = x.Length / 2;
 
            //Stores the number of occcurences of each item in the passed array in a dictionary
            foreach (int i in x)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);
            //No majority element
            throw new Exception("No majority element in array");
        }
    }
}
