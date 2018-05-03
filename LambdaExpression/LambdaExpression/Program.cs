using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace LambdaExpression
{
    class Film
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var films = new List<Film>
            {
                new Film{ Name = "Jaws", Year = 1975},
                new Film{Name = "Singing in the Rain", Year = 1952},
                new Film{Name = "Some like it Hot", Year = 1959},
                new Film{Name = "The wizard of Oz",Year = 1939},
                new Film{Name = "It's a Wonderful Life",Year = 1946},
                new Film{Name = "American Beauty", Year = 1999},
                new Film{Name = "High Fidelity", Year = 2000},
                new Film{Name = "The Usual Suspects,", Year = 1995}
            };//Object initializer

            //Creates reusable list-printing delegate (named delegate print) 
            Action<Film> print =
                film => Console.WriteLine("Name = {0}, Year={1}", film.Name, film.Year);
            //Prints original list(delegate print passed as a parameter)
            films.ForEach(print);
            //Creates filtered list
            films.FindAll(film => film.Year < 1960)
                .ForEach(print);
            //sorts original list
            films.Sort((f1, f2) => f1.Name.CompareTo(f2.Name));
            films.ForEach(print);

            //Logging events using lamda expressions
            //Button button = new Button { Text = "Click me" };

            Console.ReadKey();
        }
        //Loging events using Lambda Expression
        static void Log(string title, object sender, EventArgs e)
        {
            Console.WriteLine("Event: {0}", title);
            Console.WriteLine("Sender: {0}", sender);
            Console.WriteLine("Arguments: {0}", e.GetType());
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(e))
            {
                string name = prop.DisplayName;
                object value = prop.GetValue(e);
                Console.WriteLine("     {0}={1}", name, value);
            }
        }
    }
}
