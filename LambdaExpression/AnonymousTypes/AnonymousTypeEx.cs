using System;

namespace AnonymousTypes
{
    class AnonymousTypeEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            //Anonymous class: no type and no name; object has var type
            //As any other type in .NET, the anonymous ones inherit the class System.
            //--Object.During compilation, the compiler will automatically redefine the 
            //methods ToString(), Equals() and GetHashCode() for us.
            var myCar = new { Color = "Red", Brand = "BMW", Speed = 180 };
            Console.WriteLine("My car is a {0} {1}.",
                myCar.Color, myCar.Brand);
            Console.WriteLine("It runs {0} km/h", myCar.Speed);
            Console.WriteLine("ToString : {0},", myCar.ToString());
            Console.WriteLine("Hash Code: {0}", myCar.GetHashCode().ToString());
            Console.WriteLine("Equals? {0}", myCar.Equals(
                new { Color = "Red", Brand = "BMW", Speed = 180}));
            Console.WriteLine("Type name: {0}", myCar.GetType().ToString());

            Console.WriteLine("\n------------Array of Anonymous Types-------------");
            var arr = new[]
            {
                new{X = 3, Y = 5 },
                new{X = 1, Y =2},
                new{X = 0, Y = 7}
            };
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadLine();
        }
    }
}
