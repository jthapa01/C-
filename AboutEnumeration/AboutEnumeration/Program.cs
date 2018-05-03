using System;

namespace AboutEnumeration
{
    class Program
    {
        enum Days
        {
            Mon, Tue, Wed, Thu, Fri, Sat, Sun
        }

        public class Coffee
        {
            public CoffeeSize size;
            public Coffee(CoffeeSize size)
            {
                this.size = size;
            }

            public CoffeeSize Size
            {
                get { return size; }
            }
            public double CalcPrice(CoffeeSize coffeeSize)
            {
                switch (coffeeSize)
                {
                    case CoffeeSize.Small:
                        return 0.20;
                    case CoffeeSize.Normal:
                        return 0.40;
                    case CoffeeSize.Double:
                        return 0.60;
                    default:
                        throw new InvalidOperationException(
                            "Unsupported coffee quantity: " + (int)coffeeSize);
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Days.Mon is Days);
            int mondayValue = (int)Days.Mon;
            Console.WriteLine(mondayValue);
            Console.WriteLine(Days.Mon);
            Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
            Coffee doubleCoffee = new Coffee(CoffeeSize.Double);

            Console.WriteLine("The {0} coffee is {1} ml.", normalCoffee.Size,(int)normalCoffee.Size);
            Console.WriteLine("The {0} coffee is {1} ml.", doubleCoffee.Size, (int)doubleCoffee.Size);



            Console.ReadKey();
        }
    }
}
