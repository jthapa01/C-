using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace LINQ
{
    class ProLINQ
    {
        static void Main(string[] args)
        {
            string[] greetings = { "hello world", "hello LINQ", "hello Apress"};
            var output = from s in greetings
                         where s.EndsWith("LINQ")
                         select s;
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            //Converting an array of strings to Integers and sorting it
            string[] numbers = {"7","9","11","25","10","45" };
            var nums = numbers.Select(s => Int32.Parse(s)).OrderBy(s=>s).ToArray();

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            //Convertng a Legacy collection into an IEnumerable<T> using Cast operator
            ArrayList arraylist = new ArrayList();
            arraylist.Add("JeevanTha");
            arraylist.Add("Jeevan");
            arraylist.Add("outstanding");
            arraylist.Add("program");

            IEnumerable<string> str = arraylist.Cast<string>() //using cast
                .Where(n => n.Length < 7);
            foreach (string st in str)
            {
                Console.WriteLine(st);
            }

            //Convertng a Legacy collection into an IEnumerable<T> using OFType operator
            IEnumerable<string> names = arraylist.OfType<string>().Where(n => n.Length > 7);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Query with intentional Exception Deferred until Enumeration
            string[] strings = { "one", "two","null", "three"};
            Console.WriteLine("before where() is called");
            IEnumerable<string> ieStrings = strings.Where(s => s.Length == 3);
            Console.WriteLine("After where() is called");
            foreach (string s in ieStrings)
            {
                Console.WriteLine("Processing "+s);
            }
            Console.ReadLine();
        }
    }
}
