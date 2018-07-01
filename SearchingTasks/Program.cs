using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsClassLibrary;

namespace SearchingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linear Searching
            List<int> sortedData = FileHandler.ReadSortedFile();
            Console.WriteLine("---Linear Search---");
            DateTime startTime = DateTime.Now;
            Searching.LinearSearch(sortedData, 1500);
            TimeSpan time = DateTime.Now - startTime;
            Console.WriteLine("-------------------");
            Console.WriteLine("Total Time: {0}.{1}", time.Seconds, time.Milliseconds);
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region Binary Searching
            List<int> sortedData2 = FileHandler.ReadSortedFile();
            int count = sortedData.Count - 1;
            Console.WriteLine("---Binary Search---");
            DateTime startTime2 = DateTime.Now;
            while (count > -1)
            {
                Searching.BinarySearch(sortedData2, count);
                count -= 1500;
            }
            TimeSpan time2 = DateTime.Now - startTime2;
            Console.WriteLine("-------------------");
            Console.WriteLine("Total Time: {0}.{1}", time2.Seconds, time2.Milliseconds);
            Console.WriteLine("-------------------");
            Console.ReadKey();
            #endregion
        }
    }
}
