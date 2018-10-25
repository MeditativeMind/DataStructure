using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Queue
{
    public class LinkedQueue<T> : IQueueDS<T>
    {
        private Node<T> front;//头节点
        private Node<T> rear;//尾节点
        private int count;

        public LinkedQueue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Clear()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                Debug.LogError("The Queue is empty!");
                return default(T);
            }
            else if(count == 1)
            {
                T temp = front.Data;
                front = rear = null;
                count = 0;
                return temp;
            }
            else
            {
                T temp = front.Data;
                front = front.Next;
                count--;
                return temp;
            }
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if(count == 0)
            {
                front = newNode;
                rear = newNode;
                count++;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
                count++;
            }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            if (front == null)
            {
                Debug.LogError("The Queue is empty!");
                return default(T);
            }
            else
            {
                return front.Data;
            }
        }
    }
}
