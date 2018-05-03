using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even Numbers
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);//using a given predicate
            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            //Extension Method
            Console.WriteLine("-------------Lambda Expression Example-----------");
            List<Dog> dogs = new List<Dog>()
            {
                new Dog{Name = "Rex", Age= 4 },
                new Dog{ Name = "Sean", Age = 0},
                new Dog{Name = "Stacy", Age = 3}
            };
            var names = dogs.Select(x => x.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---------Lambda with Anonymous Types-------------");
            //Using Lambda Expressions with Anonymous Types
            var newDogsList = dogs.Select(
                x => new { DogAge = x.Age, FirstLetter = x.Name[0] });
            foreach (var item in newDogsList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------Sorting with Lambda Expression-------------");
            //Sorting with Lambda Expression
            var sortedDogs = dogs.OrderByDescending(x => x.Name);
            foreach (var dog in sortedDogs) {
                Console.WriteLine(string.Format("Dog{0} is {1} years old.",dog.Name, dog.Age));
            }

            Console.WriteLine("\n---------Statements in Lambda Expression-------------");
            //Statements in Lambda Expression
            List<int> list1 = new List<int>() { 20,1,4,8,9,44};
            //Process each arguments with code statements
            var evenNumbersInList = list1.FindAll((i) =>
            {
                Console.WriteLine("Value of i is {0}", i);
                return (i % 2) == 0;
            });
            Console.Write("Even Numbers are: ");
            foreach (var item in evenNumbersInList)
            {
                Console.Write(item + " ");
            }

            //Lambda Expression as Delegates
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\nLambda Expression as Delegates");
            Func<bool> boolFunc = () => true;//no input parameters and returns boolean result
            //Anonymous lambda function that does nothing and always returns true
            Func<int, bool> intFunc = (x) => x < 10;//takes int and returns out(bool)
            if(boolFunc() && intFunc(5))
            {
                Console.WriteLine("\n5<10");
            }


            Console.ReadLine();
            

        }
    }
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
