using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class StackQueue
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1. John");
            stack.Push("2. Nicolas");
            stack.Push("3. Mary");
            stack.Push("4. George");
            Console.WriteLine("Top = " + stack.Peek());
            while (stack.Count > 0)
            {
                string personName = stack.Pop();
                Console.WriteLine(personName);
            }

            //Correct Brackets Check
            string expression = "1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))";
            Stack<int> stack1 = new Stack<int>();
            bool correctBrackets = true;

            for (int index = 0; index < expression.Length; index++)
            {
                char ch = expression[index];
                if (ch == '(')
                {
                    stack1.Push(index);
                }
                else if(ch==')')
                {
                    if (stack1.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    stack1.Pop();
                }
            }
            if(stack1.Count != 0)
            {
                correctBrackets = false;
            }
            Console.WriteLine("Are the brackets correct? " + correctBrackets);

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Message one");
            queue.Enqueue("Message Two");
            queue.Enqueue("Message Three");
            queue.Enqueue("Message Four");

            while(queue.Count > 0)
            {
                string msg = queue.Dequeue();
                Console.WriteLine(msg);
            }

            // As you can see, the process lies in retrieving elements from the beginning of the queue 
            //and placing others in its end. Let’s see the sample implementation,//
            // in which N = 3 and we search for the number of the element with value 16:
            //Sequence N, N+1, 2*N

            int n = 3;
            int p = 16;
            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(n);
            int index1 = 0;
            Console.Write("S =");
            while(queue1.Count > 0)
            {
                index1++;
                int current = queue1.Dequeue();
                Console.WriteLine(" " + current);
                if(current == p)
                {
                    Console.WriteLine();
                    Console.WriteLine("Index = " + index1);
                    return;
                }
                queue1.Enqueue(current + 1);
                queue1.Enqueue(2 * current);
            }


            Console.ReadKey();
        }
    }
}
