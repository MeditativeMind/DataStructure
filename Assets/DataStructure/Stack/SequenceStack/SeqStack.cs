using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Stack
{
    //顺序栈 
    public class SeqStack<T> : IStackDS<T>
    {
        private T[] data;
        private int top;
        public SeqStack(int size)
        {
            data = new T[size];
            top = -1;
        }
        public SeqStack():this(50){ }

        public int Count
        {
            get
            {
                return top + 1;
            }
        }

        public void Clear()
        {
            top = -1;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public T Peek()
        {
            if (top < 0)
            {
                Debug.LogError("The stack is empty!");
                return default(T);
            }
            return data[top];
        }

        public T Pop()
        {
            if(top < 0 )
            {
                Debug.LogError("The stack is empty!");
                return default(T);
            }
            T item = data[top];
            top--;
            return item;
        }

        public void Push(T item)
        {
            if(Count == data.Length)
            {
                Debug.LogError("The Stack is full!");
                return;
            }
            data[top + 1] = item;
            top++;
        }
       
    }
}
