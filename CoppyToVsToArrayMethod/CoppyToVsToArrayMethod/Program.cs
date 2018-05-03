using System;
using System.Collections;

namespace CoppyToVsToArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            for (int i = 20; i > 0; i--)
            {
                myStack.Push(i);
            }
            object[] myArray = new object[myStack.Count];
           // myStack.CopyTo(myArray, 0);//copy to array starting at index 0

            //Stack myNewStack = new Stack();
            //for (int i = 0; i > 0 ; i++)
            //{
            //    myStack.Push(i);
            //}
            myArray = myStack.ToArray();
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
