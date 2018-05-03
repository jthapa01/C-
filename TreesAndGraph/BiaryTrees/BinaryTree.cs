﻿using System;
using System.Collections.Generic;

namespace BiaryTrees
{
    /// <summary>Represents a binary tree</summary>
    /// <typeparam name="T">Type of values in the tree</typeparam>
    public class BinaryTree<T>
    {
        /// <summary>
        /// The value stored in the current node
        /// </summary>
        /// <param name="args"></param>
        public T Value { get; set; }
        /// <summary>The left child of the current node</summary>
        public BinaryTree<T> LeftChild { get; private set; }

        /// <summary>The right child of the current node</summary>
        public BinaryTree<T> RightChild { get; private set; }

        /// <summary>Constructs a binary tree</summary>
        /// <param name="value">the value of the tree node</param>
        /// <param name="leftChild">the left child of the tree</param>
        /// <param name="rightChild">the right child of the tree
        /// </param>
        public BinaryTree(T value,
            BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        /// <summary>Constructs a binary tree with no children
        /// </summary>
        /// <param name="value">the value of the tree node</param>
        public BinaryTree(T value): this(value, null,null)
        {

        }

        /// <summary>
        /// Traverses the binary tree in pre-order
        /// </summary>
        /// <param name="args"></param>
        /// 
        public void PrintInOrder()
        {
            //1.Visit the left child
            if(this.LeftChild != null)
            {
                this.LeftChild.PrintInOrder();
            }

            //2. Visit the root of the sub-tree
            Console.Write(this.Value + " ");

            //3.Visit the right child
            if(this.RightChild != null)
            {
                this.RightChild.PrintInOrder();
            }
        }
    }
    public class BinaryTreeExample
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Demonstrates how the BinaryTree<T> class can be used
            /// </summary>
            /// 
            // Create the binary tree from the sample
            BinaryTree<int> binaryTree =
                        new BinaryTree<int>(14,
                             new BinaryTree<int>(19,
                                    new BinaryTree<int>(23),
                                    new BinaryTree<int>(6,
                                          new BinaryTree<int>(10),
                                          new BinaryTree<int>(21))),
                             new BinaryTree<int>(15,
                                    new BinaryTree<int>(3),
                                    null));
            // Traverse and print the tree in in-order manner
            binaryTree.PrintInOrder();
            Console.WriteLine();
            Console.ReadKey();

            // Console output:
            // 23 19 10 6 21 14 3 15

        }
    }
}
