using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Stack
{
    public interface IStackDS<T>
    {
        int Count { get; }
        bool IsEmpty();
        void Clear();
        void Push(T item);
        T Pop();
        T Peek();
    }
}
