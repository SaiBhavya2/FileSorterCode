using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSorter
{
    class FileWriter
    {
        public static void Written(List<string> SortedList)
        {
            string newFileName = @"C:\Users\Bhavya\Desktop\SortedNamesFile.txt";

            FileError.FError(newFileName);

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(newFileName, SortedList);

            Console.WriteLine("All entries are written");

        }
    }
}
