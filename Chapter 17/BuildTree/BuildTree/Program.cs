using System;
using BinaryTree;
namespace BuildTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<char> charTree = null;
            InsertIntoTree<char>(ref charTree, 'M', 'X', 'A', 'M', 'Z', 'Z', 'N');
            string sortedData = charTree.WalkTree();
            Console.WriteLine($"Sorted data is: {sortedData}");
            Console.ReadLine();
        }

        static void InsertIntoTree<TItem>(ref Tree<TItem> tree, 
            params TItem[] data) where TItem:IComparable<TItem>
        {
            foreach(TItem datanum in data)
            {
                if (tree==null)
                {
                    tree = new Tree<TItem>(datanum);
                }
                else
                {
                    tree.Insert(datanum);
                }
            }
        }
    }
}
