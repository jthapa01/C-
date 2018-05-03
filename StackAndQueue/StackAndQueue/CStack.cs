using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackAndQueue
{
    class CStack
    {
        private int p_index;
        private ArrayList list;

        public CStack()
        {
            list = new ArrayList();
            p_index = -1;
        }
        public int count
        {
            get
            {
                return list.Count;
            }
        }
        public void push(object item)
        {
            list.Add(item);
            p_index++;
        }
        public object pop()
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }
        public void clear()
        {
            list.Clear();
            p_index = -1;
        }
        public object peek()
        {
            return list[p_index];
        }



        static void Main(string[] args)
        {
            CStack alist = new CStack();
            string ch;
            string word = "sees";
            bool isPalindrome = true;
            for(int i = 0; i <  word.Length; i++)
            {
                alist.push(word.Substring(i, 1));
            }
            int pos = 0;
            while (alist.count > 0)
            {
                ch = alist.pop().ToString();
                if(ch != word.Substring(pos, 1))
                {
                    isPalindrome = false;
                    break;
                }
                pos++;

            }
            if (isPalindrome)
            {
                Console.WriteLine(word + " is a Palindrome.");
            }
            else
            {
                Console.WriteLine(word + "is not a Plindrome");
            }
            Console.Read();
        }
    }
}
