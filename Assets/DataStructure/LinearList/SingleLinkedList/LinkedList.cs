using LinearList;
using System;
using UnityEngine;

namespace SingleLinkedList
{
    public class LinkedList<T> : IListDS<T>
    {
        private Node<T> head;
        public LinkedList()
        {
            head = null;
        }
        public int Count
        {
            get
            {
                Node<T> temp = head;
                int count = 0;
                while (temp != null)
                {
                    count++;
                    temp = temp.Next;
                }
                return count;
            }
        }

        public T this[int index]
        {
            get
            {
                return GetElement(index);
            }
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            //1、如果头结点是空
            if(head == null)
            {
                head = newNode;
            }
            //2、如果头结点不为空
            else
            {
                Node<T> temp = head;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        public void Insert(T item, int index)
        {
            if(IsEmpty())
            {
                Debug.LogError("The LinkerList is null!");
                return;
            }
            else if (index < 0 || index > Count)
            {
                Debug.LogError("The index is error!");
                return;
            }
            Node<T> newNode = new Node<T>(item);
            if(index == 0)//添加到头部
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                int tempIndex = 0;
                while (temp.Next != null)
                {
                    tempIndex++;
                    if(tempIndex == index)
                    {
                        break;
                    }
                    temp = temp.Next;
                }
                Node<T> nextNode = temp.Next;
                temp.Next = newNode;
                newNode.Next = nextNode;
            }
        }


        public void Clear()
        {
            head = null;
        }

        public T Delete(int index)
        {
            if (IsEmpty())
            {
                Debug.LogError("The LinkerList is null!");
                return default(T);
            }
            else if (index < 0 || index > Count)
            {
                Debug.LogError("The index is error!");
                return default(T);
            }
            else
            {
                Node<T> temp = head;
                Node<T> preNode = null;
                int tempIndex = 0;
                while(tempIndex != index)
                {
                    tempIndex++;
                    preNode = temp;
                    temp = temp.Next;
                }
                preNode.Next = temp.Next;
                return temp.Data;
            }
        }

        public T GetElement(int index)
        {
            if (IsEmpty())
            {
                Debug.LogError("The LinkerList is null!");
                return default(T);
            }
            else if (index < 0 || index > Count)
            {
                Debug.LogError("The index is error!");
                return default(T);
            }
            else
            {
                Node<T> temp = head;
                int tempIndex = 0;
                while (temp.Next != null && tempIndex < index)
                {
                    tempIndex++;
                    temp = temp.Next;
                }
                if (tempIndex == index)
                {
                    return temp.Data;
                }
                else
                    return default(T);
            }
         
        }

        
        public bool IsEmpty()
        {
            return head == null;
        }

        public int LocateElement(T item)
        {
            if (IsEmpty())
            {
                Debug.LogError("The LinkerList is null!");
                return -1;
            }
            else
            {
                int index = 0;
                Node<T> temp = head;
                while(temp.Next !=null)
                {
                    if(temp.Data.Equals(item))
                    {
                        return index;
                    }
                    index++;
                    temp = temp.Next;
                }
                return -1;
            }
        }
    }
}
