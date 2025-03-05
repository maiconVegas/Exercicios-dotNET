using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.sum_of_multiples;
public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        for (int i = 1; i < max; i++)
        {
            foreach (int m in multiples)
            {
                if (m != 0 && i % m == 0)
                {
                    sum += i;
                    break;
                }
            }
        }
        return sum;
    }
}
