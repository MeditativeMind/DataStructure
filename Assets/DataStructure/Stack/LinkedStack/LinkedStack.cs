using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Stack
{
    //链式栈
    public class LinkedStack<T> : IStackDS<T>
    {
        private Node<T> head;
        public LinkedStack()
        {
            head = null;
        }
        public int Count
        {
            get
            {
                int tempIndex = 0;
                if(head == null)
                    return 0;
                Node<T> temp = head;
                while(temp.Next != null)
                {
                    tempIndex++;
                    temp = temp.Next;
                }
                return tempIndex;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
        /// <summary>
        /// 取得链栈栈顶元素不删除
        /// </summary>
        public T Peek()
        {
            return head.Data;
        }
        /// <summary>
        /// 取得链栈栈顶元素并删除
        /// </summary>
        public T Pop()
        {
            T item = head.Data;
            head = head.Next;
            return item;
        }
        /// <summary>
        /// 添加一个元素到栈顶
        /// </summary>
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = head;
            head = newNode;
        }
    }
}
