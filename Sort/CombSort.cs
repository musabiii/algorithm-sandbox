
namespace Algorithms.Sort
{
    public class CombSort
    {
        static public List<int> Run(List<int> ls)
        {
            const double shrink = 1.3;
            int gap = ls.Count;
            bool sorted = false;

            while (gap > 1 && !sorted)
            {

                gap = (int)(gap / shrink);

                int i = 0;
                while (i + gap < ls.Count)
                {
                    if (ls[i] > ls[i + gap])
                    {
                        Tools.Swap(ls,i,i+gap);
                        sorted = false;
                    }
                    i++;
                }

            }



            return ls;
        }
    }
}