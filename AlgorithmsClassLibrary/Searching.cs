using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsClassLibrary
{
    public static class Searching
    {
        public static void LinearSearch(List<int> data, int pInt)
        {
            int i;
            int interval = pInt;
            int count = pInt;

            for (i = data.Count - 1; i > -1; i--)
            {
                if (count == interval)
                {
                    Console.WriteLine(data[i]);
                    count = 1;
                    continue;
                }

                count++;
            }
        }

        public static bool BinarySearch(List<int> data, int x)
        {
            int minVal = 0;
            int maxVal = x;

            while (minVal <= maxVal)
            {
                int midVal = ((minVal + (maxVal + 1) / 2) - 1);
                
                if (midVal == x)
                {
                    Console.WriteLine(data[midVal]);
                    return true;
                }
                else if (midVal > x)
                {
                    maxVal = midVal - 1;
                }
                else
                {
                    minVal = midVal + 1;
                }
            }
            return false;
        }
    }
}
