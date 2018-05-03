using System;

namespace EnumInsideClass
{
    class Coffee
    {
        //Enumeration declared inside a class
        public  enum CoffeeSize
        {
            Small = 100, Normal =150, Double = 300
        }
        //Instance variable of enumerated type
        private CoffeeSize size;
        public Coffee(CoffeeSize size)
        {
            this.size = size;
        }
        public CoffeeSize Size
        {
            get { return size; }
        }
        public double CalcPrice(Coffee.CoffeeSize coffeeSize)
        {
            switch (coffeeSize)
            {
                case Coffee.CoffeeSize.Small:
                    return 0.20;
                case Coffee.CoffeeSize.Normal:
                    return 0.40;
                case Coffee.CoffeeSize.Double:
                    return 0.60;
                default:
                    throw new InvalidOperationException(
                        "Unsupported coffee quantity: " + ((int)coffeeSize));
            }
        }
        static void Main(string[] args)
        {
            Coffee newCoffee = new Coffee(CoffeeSize.Small);
            Console.WriteLine(newCoffee.CalcPrice(CoffeeSize.Small));
            Console.ReadKey();
        }
    }
}
