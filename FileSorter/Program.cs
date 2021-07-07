using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileSorter
{
    class FileNamesSorter
    {

        static void Main(string[] args)
        {

            string fileName = FileLoader.Loader();
            List<string> lines = ReadFile.FRead(fileName);
            List<People> peopleList = FileOperations.FileOperate(lines);
            List<string> output = SortingLinq.Sorted(peopleList);
            FileWriter.Written(output);

        }
            
            

            //Console.ReadLine();

  
    }
}

               

    

    

 