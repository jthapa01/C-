using System;

namespace BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }

        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            LeftTree = null;
            RightTree = null;
        }
        //Examine the value of the node, N, of the tree, B
        //If the value of N is greater than that of the new item, I
        //Then
        //  If the left subtree of B is empty
        //  Then
        //      Construct a new left subtree of B with the item I as the node, and empty
        //      left and right subtrees
        //  Else
        //      Insert I into the left subtree of B
        //End If
        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                //Insert the new item into the left subtree
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                //Insert the new item into the right subtree
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }

            }
        }
        public string WalkTree()
        {
            //If the left subtree is not empty
            //Then
            //  Display the contents of the left subtree
            //End If
            //Display the value of the node
            //If the right subtree is not empty
            //Then
            //  Display the contents of the right subtree
            //End If
            string result = "";
            if (this.LeftTree != null)
            {
                result = this.LeftTree.WalkTree();
            }
            result += $" {this.NodeData.ToString()} ";
            if (this.RightTree != null)
            {
                result += this.RightTree.WalkTree();
            }
            return result;
        }
    }


}
