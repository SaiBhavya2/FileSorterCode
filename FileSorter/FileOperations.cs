using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSorter
{  
    class FileOperations
    {
        public static List<People> FileOperate(List<string> lines)
        {
            List<People> people = new List<People>();


            foreach (var line in lines)
            {
                string[] entries = line.Split(" ");

                People newPerson = new People();


                if (entries.Length == 1)
                {
                    newPerson.FirstName = entries[0];
                }

                else if (entries.Length == 2)
                {
                    newPerson.FirstName = entries[0];
                    newPerson.LastName = entries[1];
                }
                else if (entries.Length == 3)
                {
                    newPerson.FirstName = entries[0];
                    newPerson.MiddleName = entries[1];
                    newPerson.LastName = entries[2];
                }
                else if (entries.Length == 4)
                {
                    newPerson.FirstName = entries[0];
                    newPerson.MiddleName = entries[1] + " " + entries[2];
                    newPerson.LastName = entries[3];
                }
                //else if (entries.Length == 0 || entries.Length > 4)
                //{
                //    Console.WriteLine("Name should be valid: Minimum 1 name and Maximum 4 names");
                //}
                //Console.WriteLine(newPerson.FirstName + newPerson.MiddleName + newPerson.LastName);

                people.Add(newPerson);

            }
            return people;


        }

        
    }
}
