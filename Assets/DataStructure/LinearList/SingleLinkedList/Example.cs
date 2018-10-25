using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SingleLinkedList
{
    public class Example : MonoBehaviour
    {
        void Start()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("1");
            list.Add("2");
            list.Insert("3",list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                print("第一次："+list[i]);
            }
            list.Delete(1);
            for (int i = 0; i < list.Count; i++)
            {
                print("第二次：" + list[i]);
            }
        }
    }
}
