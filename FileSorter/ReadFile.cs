using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSorter
{
    class ReadFile
    {
        
        public static List<string> FRead(string FName)
        {
            List<string> lines = new List<string>(File.ReadAllLines(FName));
            return lines;

        }
    }
}
