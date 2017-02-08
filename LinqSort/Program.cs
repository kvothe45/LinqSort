using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 0, 5, 4, 6, 95, 2, 4, 33, 7, 55, 6, 1 };
            var list = SortArray(array);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }


            var firstNameList = new List<First>();
            firstNameList.Add(new First() { PersonId = 1, FirstName = "SpongeBob" });
            firstNameList.Add(new First() { PersonId = 2, FirstName = "Patrick" });
            firstNameList.Add(new First() { PersonId = 3, FirstName = "Sandy" });

            var lastNameList = new List<Last>();
            lastNameList.Add(new Last() { PersonId = 1, LastName = "SquarePants", EMail = "sponge@kraby.com" });
            lastNameList.Add(new Last() { PersonId = 2, LastName = "Star", EMail = "patrick@kraby.com" });
            lastNameList.Add(new Last() { PersonId = 3, LastName = "Squirrel", EMail = "sandy@kraby.com" });

            var joined = (from First in firstNameList
                          join Last in lastNameList
                          on First.PersonId equals Last.PersonId
                          select new { First, Last }).ToList();

            foreach (var element in joined)
            {
                Console.Write(element.First.PersonId);
                Console.Write("  ");
                Console.Write(element.First.FirstName);
                Console.Write("  ");
                Console.Write(element.Last.LastName);
                Console.Write("  ");
                Console.WriteLine(element.Last.EMail);
            }


            Console.ReadLine();
        }

        public static List<int> SortArray(int[] array)
        {
            var list = array.OrderBy(n => n).ToList();

            return list;
        }
    }
}
