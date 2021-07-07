using System;
using System.Collections.Generic;
using System.Text;

namespace FileSorter
{
    class FileLoader
    {
        public static string Loader()
        {
            string fileName = @"C:\Users\Bhavya\Desktop\Unsorted.txt";

            FileError.FError(fileName);

            return fileName;
        }

        
    }
}
