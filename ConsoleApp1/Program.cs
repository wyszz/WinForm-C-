using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            bool flag = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    flag = true;
                    break;
                }
            }
            return flag;
            Console.WriteLine(flag);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
