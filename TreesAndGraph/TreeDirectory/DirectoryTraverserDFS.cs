using System;
using System.IO;

namespace TreeDirectory
{
    /// <summary>
    /// Sample class, which traverses recursively given directory
    /// based on the Depth-First-Search (DFS) algorithm
    /// </summary>
    public static class DirectoryTraverserDFS
    {
        /// <summary>
        /// Traverses and prints given directory recursively
        /// </summary>
        /// <param name="dir">the directory to be traversed</param>
        /// <param name="spaces">the spaces used for representation
        /// of the parent-child relation</param>
        private static void TraverseDir(DirectoryInfo dir, string spaces)
        {
            //Visit the current directory
            Console.WriteLine(spaces+dir.FullName);
            DirectoryInfo[] children = dir.GetDirectories();

            //For each child go and visit its sub-tree
            foreach (DirectoryInfo child in children)
            {
                TraverseDir(child, spaces + " ");
            }
        }
        /// <summary>
        /// Traverses and prints given directory recursively
        /// </summary>
        /// <param name="directoryPath">the path to the directory
        /// which should be traversed</param>
        static void TraverseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath),string.Empty);
        }



        //There are multiple algorithms to traverse a tree but in this chapter
        //we will discuss only two of them: DFS (depth-first search)
        // and BFS (breadth-first search).

        static void Main(string[] args)
        {
            TraverseDir("C:\\Users\\New Laptop\\source\\repos\\Classes");
            Console.ReadKey();
        }
    }
}
