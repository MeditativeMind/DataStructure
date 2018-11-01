using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BinaryTree.Sequence
{
    //完全二叉树 顺序存储
    public class BiTree<T>
    {
        private T[] data;
        private int count;
        public BiTree(int capcity)
        {
            data = new T[capcity];
        }
        public BiTree() : this(20) { }

        public void Add(T item)
        {
            if (count > data.Length - 1)
                return;
            data[count] = item;
            count++;
        }
        /// <summary>
        /// 先序遍历
        /// </summary>
        public void PreorderTraversal()
        {
            PreorderTraversal(0);
        }
        /// <summary>
        /// 中序遍历
        /// </summary>
        public void InorderTraversal()
        {
            InorderTraversal(0);
        }
        /// <summary>
        /// 后序遍历
        /// </summary>
        public void PostorderTraversal()
        {
            PostorderTraversal(0);
        }
        /// <summary>
        /// 层序遍历
        /// </summary>
        public void LevelOrder()
        {
            for (int i = 0; i < count; i++)
            {
                Debug.Log(data[i]);
            }
        }
        private void PreorderTraversal(int index)
        {
            if (index > count - 1) return;
            Debug.Log(data[index]);
            int number = index + 1;
            int leftChild = number * 2;
            int rightChild = number * 2 + 1;
            PreorderTraversal(leftChild - 1);
            PreorderTraversal(rightChild - 1);
        }
        private void InorderTraversal(int index)
        {
            if (index > count - 1) return;
            int number = index + 1;
            int leftChild = number * 2;
            int rightChild = number * 2 + 1;
            InorderTraversal(leftChild - 1);
            Debug.Log(data[index]);
            InorderTraversal(rightChild - 1);
        }
        private void PostorderTraversal(int index)
        {
            if (index > count - 1) return;
            int number = index + 1;
            int leftChild = number * 2;
            int rightChild = number * 2 + 1;
            PostorderTraversal(leftChild - 1);
            PostorderTraversal(rightChild - 1);
            Debug.Log(data[index]);
        }
    }
}
