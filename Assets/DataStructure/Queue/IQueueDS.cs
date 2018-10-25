using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Queue
{
    public interface IQueueDS<T>
    {
        int Count { get; }
        bool IsEmpty();
        void Clear();
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    }
}
