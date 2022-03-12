using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int ret = 0;
            foreach (int e in nums) ret ^= e;
            return ret;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            int []p = { 1, 2, 3, 4, 5 };
            so.SingleNumber(p);
        }
    }
}
