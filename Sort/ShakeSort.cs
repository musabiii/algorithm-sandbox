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
                        Tools.Swap(ls, i, i + 1);
                        swapped = true;
                    }
                    i++;
                }

                int j = EndIndex - 1;

                while (j > StartIndex)
                {
                    if (ls[j - 1] > ls[j])
                    {
                        Tools.Swap(ls, j, j - 1);
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