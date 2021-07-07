using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSorter
{
    class FileError
    {
        public static void FError(string FName)
        {
            if (File.Exists(FName))
            {
                Console.WriteLine("File is present");
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
