using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Stack
{
    public class Node<T>
    {
        private T data;//数据域 当前节点的数据
        private Node<T> next; //引用域,下一个节点
        public Node()
        {
            data = default(T);
            next = null;
        }
        //构造器：数据域+引用域
        public Node(Node<T> next, T data)
        {
            this.next = next;
            this.data = data;
        }
        //构造器：引用域，头结点
        public Node(Node<T> next)
        {
            this.next = next;
        }
        //构造器：数据域，尾结点
        public Node(T data)
        {
            this.data = data;
            next = null;
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
    }
}
