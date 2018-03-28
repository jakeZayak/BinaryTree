namespace YTCBinaryTreeSpring2018
{
    class BinaryTree<T>
    {
        private BinaryTreeNode<T> root = null;

        public BinaryTree()
        {
            root = null;
        }

        public virtual void Clear()
        {
            root = null;
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }

        private string InOrder(BinaryTreeNode<T> current)
        {
            string tree = string.Empty;

            if(current != null)
            {
                tree += InOrder(current.Left);
                tree += current.ToString() + " ";
                tree += InOrder(current.Right);
            }

            return tree;
        }

        public string InOrderTrav()
        {
            return InOrder(root);
        }

        public override string ToString()
        {
            return InOrder(root);
        }
    }
}
