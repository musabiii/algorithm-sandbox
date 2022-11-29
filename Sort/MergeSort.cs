using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    public class MergeSort
    {
        static public List<int> Run(List<int> ls)
        {

            if (ls.Count == 1)
            {
                return ls;
            }

            double mid = ls.Count / 2;
            int middle = (int)Math.Floor(mid);

            var left = ls.GetRange(0, middle);
            var right = ls.GetRange(middle, ls.Count - middle);

            return Merge(Run(left), Run(right));
        }

        static public List<int> Merge(List<int> left, List<int> right)
        {
            List<int> Result = new List<int> { };
            int leftIndex = 0;
            int rightIndex = 0;

            int last = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {

                if (left[leftIndex] > right[rightIndex])
                {
                    Result.Add(left[leftIndex]);
                    leftIndex++;
                    last = right[right.Count - 1];
                }
                else
                {
                    Result.Add(right[rightIndex]);
                    rightIndex++;
                    last = left[left.Count - 1];
                }
            }

            var leftRemain = leftIndex < left.Count ? left.GetRange(leftIndex, left.Count - leftIndex) : new List<int> { };
            var rightRemain = rightIndex < right.Count ? right.GetRange(rightIndex, right.Count - rightIndex) : new List<int> { };

            return Result.Concat(leftRemain).Concat(rightRemain).ToList();
            // return Result;
        }
    }
}