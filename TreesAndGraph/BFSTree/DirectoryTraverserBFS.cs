using System;
using System.Collections.Generic;
using System.IO;

namespace BFSTree
{
    /// <summary>
    /// Sample class, which traverses given directory
    /// based on the Breadth-First-Search (BFS) algorithm
    /// </summary>
    public static class DirectoryTraverserBFS
    {
        /// <summary>
        /// Traverses and prints given directory with BFS
        /// </summary>
        /// <param name="directoryPath">the path to the directory         
        /// /// which should be traversed</param>
        static void TraverseDir(string directorypath)
        {
            Queue<DirectoryInfo> visitedDirsQueue =
                new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directorypath));
            while(visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currenDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currenDir.FullName);

                DirectoryInfo[] children = currenDir.GetDirectories();
                foreach(DirectoryInfo child in children)
                {
                    visitedDirsQueue.Enqueue(child);
                }
            }
        }




        static void Main(string[] args)
        {
            TraverseDir(@"C:\Users\New Laptop\source\repos\Classes\Classes");
            Console.ReadKey();
        }
    }
}
