using System;

namespace YTCBinaryTreeSpring2018
{
    class BinarySearchTree<T> : BinaryTree<T>
    {
        public BinarySearchTree() : base() { }

        public void Add(T item)
        {
            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(item);

            int compResult;

            BinaryTreeNode<T> current = Root;
            BinaryTreeNode<T> parent = null; 

            while (current != null)
            {
                compResult = ((IComparable<T>)(current.Item)).CompareTo(item);

                if (compResult == 0) //Item and node data equal
                {
                    return;
                }
                else if (compResult > 0) // Node data is greater than item, go Leftsed on BST priority
                {
                    parent = current;
                    current = current.Left;
                }
                else if (compResult < 0) // Node data is less than item, go right
                {
                    parent = current;
                    current = current.Right;
                }
            }

            if (parent == null)
            {
                Root = newNode;
            }
            else
            {
                compResult = ((IComparable<T>)(parent.Item)).CompareTo(item);

                if (compResult > 0) //parent > data, goes left
                {
                    parent.Left = newNode;

                }
                else // parent < data, goes right
                {
                    parent.Right = newNode;
                }
            }
        }


    }
}
