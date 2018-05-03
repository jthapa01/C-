using System;
using System.Collections.Generic;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension methods allow an existing type to be 
            //extended with new methods without altering the defn 
            //of the original type, statc method of static class
            // where this modifier is applied to the first parameter

            //THe ISCapitalized extension method can be called as though
            //it were an instance method on a string, as follows
            Console.WriteLine("Perth".IsCapitalized());

            Console.WriteLine("Seatle".First());

            //Extension method vs extension method
            //If two ext methods have same same signature, the extension method
            //must be alled as an ordinary static method to disambigaute the method'
            //call. the more specific takes precedence





            Console.ReadLine();
        }

    }

    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            return char.IsUpper(s[0]);
        }


        public static T First<T>(this IEnumerable<T> sequence)
        {
            foreach(T element in sequence)
            {
                return element;
            }
            throw new InvalidOperationException("No elements!");
        }

        
    }
}

