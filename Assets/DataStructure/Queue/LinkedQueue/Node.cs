using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Queue
{
    public class Node<T>
    {
        private T data;//数据域 当前节点的数据
        private Node<T> next;//引用域,下一个节点
        public Node(T data)
        {
            this.data = data;
        }
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }

        }

    }
}
