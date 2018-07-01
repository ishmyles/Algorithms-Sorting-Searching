using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsClassLibrary
{
    public static class Sorting
    {
        public static List<int> InsertionSort(List<int> unsortedList)
        {
            for (int i = 0; i < unsortedList.Count - 1; i++)
            {
                for (int n = i + 1; n > 0; n--)
                {
                    if (unsortedList[n - 1] > unsortedList[n])
                    {
                        int temp = unsortedList[n - 1];
                        unsortedList[n - 1] = unsortedList[n];
                        unsortedList[n] = temp;
                    }
                }
            }

            return unsortedList;
        }

        public static List<int> ShellSort(List<int> unsortedList, int splt)
        {
            int i;
            int n;
            int temp;
            int listSize = unsortedList.Count - 1;

            while (splt > 0)
            {
                for (i = 0; i < listSize; i++)
                {
                    n = i;
                    temp = unsortedList[i];
                    while ((n >= splt) && (unsortedList[n - splt] > temp))
                    {
                        unsortedList[n] = unsortedList[n - splt];
                        n = n - splt;
                    }
                    unsortedList[n] = temp;
                }
                if (splt / 2 != 0)
                    splt = splt / 2;
                else if (splt == 1)
                    splt = 0;
                else
                    splt = 1;
            }

            return unsortedList;
        }
    }
}
