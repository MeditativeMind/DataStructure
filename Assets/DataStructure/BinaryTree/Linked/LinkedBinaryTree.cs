using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BinaryTree.Linked
{
    public class LinkedBinaryTree<T>
    {
        private TreeNode<T> head;//头引用
        public TreeNode<T> Head { get { return head; } set { head = value; } }
        #region 构造函数
        public LinkedBinaryTree()
        {
            head = null;
        }
        public LinkedBinaryTree(T headData)
        {
            head = new TreeNode<T>(headData);
        }
        public LinkedBinaryTree(T headData, TreeNode<T> left, TreeNode<T> right)
        {
            head = new TreeNode<T>(headData, left, right);
        }
        #endregion

        public bool IsEmpty()
        {
            return head == null;
        }
        /// <summary>
        /// 获取根节点
        /// </summary>
        /// <returns></returns>
        public TreeNode<T> Root()
        {
            return head;
        }
        public TreeNode<T> GetLeftChild(TreeNode<T> nowNode)
        {
            return nowNode.LeftChild;
        }
        public TreeNode<T> GetRightChild(TreeNode<T> nowNode)
        {
            return nowNode.RightChild;
        }
        //将结点node的左子树插入值为item的新结点，原来的左子树称为新结点的左子树
        public void InsertLeft(T item ,TreeNode<T> node)
        {
            TreeNode<T> newNode = new TreeNode<T>(item);
            newNode.LeftChild = node.LeftChild;
            node.LeftChild = newNode;
        }
        public void InsertRight(T item, TreeNode<T> node)
        {
            TreeNode<T> newNode = new TreeNode<T>(item);
            newNode.RightChild = node.RightChild;
            node.RightChild = newNode;
        }
        public TreeNode<T> DeleteLeft(TreeNode<T> node)
        {
            if (node == null || node.LeftChild == null)
                return null;
            TreeNode<T> temp = node.LeftChild;
            node.LeftChild = null;
            return temp;
        }
        public TreeNode<T> DeleteRight(TreeNode<T> node)
        {
            if (node == null || node.RightChild == null)
                return null;
            TreeNode<T> temp = node.RightChild;
            node.RightChild = null;
            return temp;
        }
        /// <summary>
        /// 先序遍历
        /// </summary>
        public void PreorderTraversal()
        {
            PreorderTraversal(head);
        }
        /// <summary>
        /// 中序遍历
        /// </summary>
        public void InorderTraversal()
        {
            InorderTraversal(head);
        }
        /// <summary>
        /// 后序遍历
        /// </summary>
        public void PostorderTraversal()
        {
            PostorderTraversal(head);
        }
        /// <summary>
        /// 层序遍历
        /// </summary>
        public List<TreeNode<T>> LevelOrder()
        {
            List<TreeNode<T>> trees = new List<TreeNode<T>>();
            trees.Add(head);
            LevelOrder(head, trees, 0);
            return trees;
        }
        private void PreorderTraversal(TreeNode<T> node)
        {
            if (IsEmpty())
                return;
            if(node != null)
            {
                Debug.Log(" " +node.Data);
                PreorderTraversal(node.LeftChild);
                PreorderTraversal(node.RightChild);
            }
        }
        private void InorderTraversal(TreeNode<T> node)
        {
            if (IsEmpty())
                return;
            if (node != null)
            {
                InorderTraversal(node.LeftChild);
                Debug.Log(" " + node.Data);
                InorderTraversal(node.RightChild);
            }
        }
        private void PostorderTraversal(TreeNode<T> node)
        {
            if (IsEmpty())
                return;
            if (node != null)
            {
                PostorderTraversal(node.LeftChild);
                PostorderTraversal(node.RightChild);
                Debug.Log(" " + node.Data);
            }
        }
        private void LevelOrder(TreeNode<T> node,List<TreeNode<T>> data,int index)
        {
            if(node.LeftChild != null)
                data.Add(node.LeftChild);
            if (node.RightChild != null)
                data.Add(node.RightChild);
            index++;
            if (index >= data.Count) return;
            LevelOrder(data[index], data, index);
        }
    }
}
