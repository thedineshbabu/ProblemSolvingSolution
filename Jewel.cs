using System.Linq;

namespace C_Sharp
{
    public static class Jewel
    {
        public static int Method1(string J, string S)
        {
            int stones = 0;

            foreach(char c in J){
                foreach(char d in S){
                    if(c == d){
                        stones++;
                    }
                }
            }
            return stones;
        }
        public static int Method2(string J, string S)
        {
            int stones = 0;
            foreach(char c in J)
            {
                stones = stones + S.ToCharArray().Where(s=>s.Equals(c)).Count();
            }
            return stones;
        }

        public static int Method3(string J, string S)
        {
            return S.ToCharArray().Where(s => J.ToCharArray().Contains(s)).Count();
        }
    }
}