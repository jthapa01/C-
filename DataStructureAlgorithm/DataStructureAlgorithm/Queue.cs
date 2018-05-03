using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithm
{
    public class Queue
    {
        private ArrayList pqueue;

        public Queue()
        {
            pqueue = new ArrayList();
        }

        public void EnQueue(object item)
        {
            pqueue.Add(item);

        }

        public void Dequeue()
        {
            pqueue.RemoveAt(0);
        }
        public object Peek()
        {
            return pqueue[0];
        }
        public void ClearQueue()
        {
            pqueue.Clear();
        }
        public int Count()
        {
            return pqueue.Count;
        }

        public void Display()
        {
            foreach (var item in pqueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
