using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Utils
{
    static public class Tools
    {
        static public void Swap(List<int> ls, int i, int j) {
                int m = ls[i];
                ls[i] = ls[j];
                ls[j] = m;
            // return ls;
        }
    }
}