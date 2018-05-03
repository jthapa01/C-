using System;
using System.Collections.Generic;
using System.Text;

namespace IDictionary
{
    class PlayWithHashDictionary
    {
        static void Main(string[] args)
        {
            IEqualityComparer<Point3D> comparer =
                new Point3DEqualityComparer();
            Dictionary<Point3D, int> dict =
                new Dictionary<Point3D, int>(comparer);

            dict[new Point3D(4, 2, 5)] = 5;
            dict[new Point3D(1, 2, 3)] = 1;
            dict[new Point3D(3, 1, -1)] = 3;
            dict[new Point3D(1, 2, 3)] = 10;

            foreach (var entry in dict)
            {
                Console.WriteLine("{0}-->{1}", entry.Key, entry.Value);
            }

            Console.WriteLine("Hello World!");

            //play with Dictionary
            Console.WriteLine("\n Play with dictionary");
            HashDictionary<Point3D, int> dictionary =
                new HashDictionary<Point3D, int>(3, 0.9f)
                {
                    [new Point3D(1, 2, 3)] = 1 // Put a key-value pair
                };
            Console.WriteLine(dictionary[new Point3D(1, 2, 3)]); // Get value

            //Overrite the previous value with the same key
            dictionary[new Point3D(1, 2, 3)] += 1;
            Console.WriteLine(dictionary[new Point3D(1, 2, 3)]);

            //now this point will cause a collison with the 
            //previous one and the elements will be chained
            dictionary[new Point3D(3,2,2)] = 42;
            Console.WriteLine(dictionary[new Point3D(3, 2, 2)]);
            // Test if the chaining works as expected, i.e.
            // elements with equal hash-codes are not overwritten
            Console.WriteLine(dictionary[new Point3D(1, 2, 3)]);
            //Creation of another entry in the internal table
            //this will cause the internal table to expand
            dictionary[new Point3D(4, 5, 6)] = 1111;
            Console.WriteLine(dictionary[new Point3D(1,2,3)]);
            //Deleting an existing by its key
            dictionary.Remove(new Point3D(3,2,2));

            //Iterate through the dictionary entries and print them
            foreach (KeyValuePair<Point3D, int> entry in dictionary)
            {
                Console.WriteLine(
                    "Key: " + entry.Key + ":Value: " + entry.Value);
            }

            Console.ReadKey();
        }
    }
}
