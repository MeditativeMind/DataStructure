

namespace BinaryTree.Linked
{
    public class TreeNode<T>
    {
        private T data;//数据域
        private TreeNode<T> leftChild;//左孩子节点
        private TreeNode<T> rightChild;//右孩子节点

        public TreeNode()
        {
            data = default(T);
            leftChild = null;
            rightChild = null;
        }
        public TreeNode(T data, TreeNode<T> leftChild, TreeNode<T> rightChild)
        {
            this.data = data;
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }
        public TreeNode(TreeNode<T> leftChild, TreeNode<T> rightChild)
        {
            data = default(T);
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }
        public TreeNode(T data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public TreeNode<T> LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        public TreeNode<T> RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }
    }
}
