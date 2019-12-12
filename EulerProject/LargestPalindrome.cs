using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class LargestPalindrome
    {

        public static int FindLargest()
        {
            var largestPalindrome = 0;
            for (var i = 999; i > 0; i--)
            {
                for (var j = 999; j >= i; j--)
                {
                    var number = i * j;
                    if (IsPalindrome(number))
                    {
                        largestPalindrome = number > largestPalindrome ? number : largestPalindrome;
                    }
                }
            }

            return largestPalindrome;
        }

        private static bool IsPalindrome(int number)
        {
            var reverse = int.Parse(number.ToString().Reverse().Aggregate("", (s, c) => s + c));
            return number == reverse;
        }
    }
}
