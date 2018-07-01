using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsClassLibrary;

namespace SortingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Insert Sort
            List<int> unsortedValues = FileHandler.ReadUnsortedFile();
            Console.WriteLine("---Insertion Sort---");
            DateTime startTime = DateTime.Now;
            List<int> sortedValues = Sorting.InsertionSort(unsortedValues);
            TimeSpan time = DateTime.Now - startTime;
            Console.WriteLine("Total Time: {0}.{1}", time.Seconds, time.Milliseconds);
            FileHandler.WriteToFile(sortedValues);
            Console.WriteLine("Sorted Numbers Saved.");
            Console.WriteLine("--------------------");
            Console.ReadKey();
            #endregion

            #region Shell Sort
            List<int> unsortedValues2 = FileHandler.ReadUnsortedFile();
            Console.Write("Enter number for gap: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("-----Shell Sort-----");
            DateTime startTime2 = DateTime.Now;
            List<int> sortedValues2 = Sorting.ShellSort(unsortedValues2, input);
            TimeSpan time2 = DateTime.Now - startTime2;
            Console.WriteLine("Total Time: {0}.{1}", time2.Seconds, time2.Milliseconds);
            FileHandler.WriteToFile(sortedValues2);
            Console.WriteLine("Sorted Numbers Saved.");
            Console.WriteLine("--------------------");
            Console.ReadKey();
            #endregion
        }
    }
}
