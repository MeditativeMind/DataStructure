using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Queue
{
    public class SeqQueue<T> : IQueueDS<T>
    {
        private T[] data;
        private int count;
        private int front;//队首
        private int rear;//队尾
        public SeqQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }
        public SeqQueue() : this(50) { }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Clear()
        {
            count = 0;
            front = -1;
            rear = -1;
        }

        public T Dequeue()
        {
            if (Count > 0)
            {
                T temp = data[front + 1];
                front++;
                count--;
                return temp;

            }
            else
            {
                Debug.LogError("The Queue is empty!");
                return default(T);
            }
        }

        public void Enqueue(T item)
        {
            if (count == data.Length)
            {
                Debug.LogError("The Queue is full!");
                return;
            }
            if (rear == data.Length - 1)
            {
                data[0] = item;
                rear = 0;
            }
            else
            {
                data[rear + 1] = item;
                rear++;
            }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            T temp = data[front + 1];
            return temp;
        }
    }
}
