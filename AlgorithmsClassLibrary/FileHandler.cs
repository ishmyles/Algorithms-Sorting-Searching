using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsClassLibrary
{
    public static class FileHandler
    {
        private static string _unsortedFile = "C:/Users/ishmyles/Desktop/Algorithms-Sorting/unsorted_numbers.csv";
        private static string _sortedFile = "C:/Users/ishmyles/Desktop/Algorithms-Sorting/sorted_numbers.csv";
        private static string _writePath = "C:/Users/ishmyles/Desktop/Algorithms-Sorting/sorted_numbers.csv";

        public static List<int> ReadUnsortedFile()
        {
            List<string> stringValues = File.ReadAllLines(_unsortedFile).ToList();
            List<int> intValues = new List<int>();

            for (int i = 0; i < stringValues.Count; i++)
            {
                intValues.Add(int.Parse(stringValues[i]));
            }

            return intValues;
        }

        public static List<int> ReadSortedFile()
        {
            List<string> stringValues = File.ReadAllLines(_sortedFile).ToList();
            List<int> intValues = new List<int>();

            for (int i = 0; i < stringValues.Count; i++)
            {
                intValues.Add(int.Parse(stringValues[i]));
            }

            return intValues;
        }

        public static void WriteToFile(List<int> sortedNums)
        {
            using (var writer = new StreamWriter(_writePath))
            {
                for (int i = 0; i < sortedNums.Count; i++)
                {
                    writer.WriteLine(sortedNums[i]);
                }
            }
        }
    }
}
