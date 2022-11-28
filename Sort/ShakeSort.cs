using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class ShakeSort
    {
        static public List<int> Run(List<int> ls)
        {

            bool swapped = false;

            int StartIndex = 0;
            int EndIndex = ls.Count() - 1;

            while (StartIndex < EndIndex)
            {

                int i = StartIndex;
                while (i < EndIndex)
                {
                    if (ls[i] > ls[i + 1])
                    {
                        int m = ls[i];
                        ls[i] = ls[i + 1];
                        ls[i + 1] = m;
                        swapped = true;
                    }
                    i++;
                }

                int j = EndIndex - 1;

                while (j > StartIndex)
                {
                    if (ls[j-1] > ls[j])
                    {
                        int m = ls[j];
                        ls[j] = ls[j - 1];
                        ls[j - 1] = m;
                        swapped = true;
                    }
                    j--;
                }

                if (!swapped)
                {
                    break;
                }

                StartIndex++;
                EndIndex--;
            }
            return ls;

        }


    }
}