using LinearList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SequenceList
{
    //顺序表
    public class SeqList<T> : IListDS<T>
    {
        public SeqList(int size)
        {
            data = new T[size];
            count = 0;
        }
        public SeqList() : this(50) { }


        private T[] data;
        private int count { get; set; }
        public T this[int index]
        {
            get
            {
                return GetElement(index);
            }
        }

        public void Add(T item)
        {
            if (count == data.Length)
            {
                Debug.Log("The sequence list is full! ");
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public T Delete(int index)
        {
            if (index >= count || index < 0)
            {
                Debug.LogError("The index is error! ");
                return default(T);
            }
            else
            {
                T temp = data[index];
                for (int i = index; i < count; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
                return temp;
            }
        }

        public T GetElement(int index)
        {
            if (index >= count || index < 0)
            {
                Debug.LogError("The index is error! ");
                return default(T);
            }
            else
            {
                return data[index];
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Insert(T item, int index )
        {
            if(count == data.Length)
            {
                Debug.Log("The sequence list is full!");
                return;
            }
            if (index < 0 || index > count)
            {
                Debug.LogError("This index does not exist! ");
            }
            else
            {
                if(index == count) //默认添加最后一个位置
                {
                    data[count] = item;
                    count++;
                }
                else
                {
                    T temp = data[index];
                    for (int i = count - 1; i >= index; i--)
                    {
                        data[i + 1] = data[i];
                    }
                    data[index] = temp;
                    count++;
                }
            }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int LocateElement(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
