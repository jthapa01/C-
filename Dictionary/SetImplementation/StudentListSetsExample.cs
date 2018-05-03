using System;
using System.Collections.Generic;

namespace SetImplementation
{
    class StudentListSetsExample
    {
        static void Main(string[] args)
        {
            //Implementation with HashTable - HashSet<T>
            HashSet<string> aspNetStudents = new HashSet<string>();
            aspNetStudents.Add("S. Jobs");
            aspNetStudents.Add("B. Gates");
            aspNetStudents.Add("M. Dell");

            HashSet<string> silverlightStudents =
                new HashSet<string>();
            silverlightStudents.Add("M. Zuckerberg");
            silverlightStudents.Add("M. Dell");

            HashSet<string> allStudents = new HashSet<string>();
            allStudents.UnionWith(aspNetStudents);
            allStudents.UnionWith(silverlightStudents);

            HashSet<string> intersectStudents =
                new HashSet<string>(aspNetStudents);
            intersectStudents.IntersectWith(silverlightStudents);

            Console.WriteLine("ASP.NET students: " +
                string.Join(", ", aspNetStudents));
            Console.WriteLine("Silverlight students: " +
                string.Join(", ", silverlightStudents));
            Console.WriteLine("All students: " +
                string.Join(", ", allStudents));
            Console.WriteLine(
                "Students in both ASP.NET and Silverlight: " +
                string.Join(", ", intersectStudents));

            //implementation with Red Black Tree-SortedSet<T>
            SortedSet<string> bandsBradLikes =
                new SortedSet<string>(new[]
                {
                    "Manowar", "Blind Guardian", "Dio", "Kiss",
                    "Dream Theater", "Megadeth", "Judas Priest",
                    "Kreator", "Iron Maiden", "Accept"
                });
            SortedSet<string> bandsAngelinaLikes =
                new SortedSet<string>(new[] 
                {
                    "Iron Maiden", "Dio", "Accept", "Manowar", "Slayer",
                    "Megadeth", "Running Wild", "Grave Gigger", "Metallica"
                });
            Console.Write("Brad Pitt likes these bands: ");
            Console.WriteLine(string.Join(", ",bandsBradLikes));

            Console.Write("Angelina Jolie likes these bands: ");
            Console.WriteLine(string.Join(",",bandsAngelinaLikes));

            SortedSet<string> intersectBands =
                new SortedSet<string>(bandsBradLikes);
            intersectBands.IntersectWith(bandsAngelinaLikes);
            Console.WriteLine(string.Format(
                "Does Brad Pitt like Angelina Jolie? {0}",
                    intersectBands.Count >= 5 ? "Yes!" : "No!"));

            Console.Write("Because Brad Pitt and Angelina Jolie both like: ");
            Console.WriteLine(string.Join(", ",intersectBands));

            SortedSet<string> unionBands = new SortedSet<string>(bandsBradLikes);
            unionBands.UnionWith(bandsAngelinaLikes);

            Console.Write(
                "All bands hat Brad Pitt or Angelina Jolie like: ");
            Console.WriteLine(string.Join(", ", unionBands));
            Console.ReadLine();
        }
    }
}
