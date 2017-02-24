/*
 * Problem description: You are climbing a stair case. It takes n steps to reach to the top.
 * Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
 * 
 * Note: Given n will be a positive integer.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingStairs
{
    public class Solution
    {
        public static int ClimbStairs(int n)
        {
            int result = 0;
            while ((n -= 2) > 1)
            {
                result += nChooseK(n + 1, 2);
            }

            // add a case of all single steps and return
            return ++result;
        }

        // n choose k formula
        private static int nChooseK(int n, int k)
        {
            return factorial(n) / (factorial(n - k) * factorial(k));
        }

        // get factorial of a number
        private static int factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * factorial(n - 1);
        }
    }
}
