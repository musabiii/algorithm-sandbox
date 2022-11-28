using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class BubbleSort
    {
        static public List<int> Run(List<int> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                for (int j = 0; j < ls.Count - i - 1; j++)
                {
                    if (ls[j] < ls[j + 1])
                    {
                        int m = ls[j];
                        ls[j] = ls[j + 1];
                        ls[j + 1] = m;
                    }
                }
            }

            return ls;

        }
    }
}