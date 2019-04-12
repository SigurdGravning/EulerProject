using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class EvenFibonacci
    {
        public static int Sum()
        {
            int result = 0;
            int i = 1, j = 1, k;

            while (i < 4000000)
            {
                k = j;
                j = i;
                i = j + k;

                if (i % 2 == 0)
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
