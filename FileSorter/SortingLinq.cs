using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileSorter
{
    class SortingLinq
    {
        public static List<string> Sorted(List<People> people)
        {
            people = people.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ThenBy(x => x.MiddleName).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.MiddleName} {person.LastName}");
            }

            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{person.FirstName} {person.MiddleName} {person.LastName}");
            }

            Console.ReadLine();

            return output;

        }
    }
}
