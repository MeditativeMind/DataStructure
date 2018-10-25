using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SequenceList
{
    public class Example : MonoBehaviour
    {
        void Start()
        {
            SeqList<string> seqList = new SeqList<string>();
            seqList.Add("初始数据");
            seqList.Clear();
            print("长度:"+seqList.Count);
            print("是否为空:" + seqList.IsEmpty());
            seqList.Add("添加数据");
            seqList.Add("第二次");
            seqList.Insert("第三次",4);
            for (int i = 0; i < seqList.Count; i++)
            {
                print("遍历:" + seqList[i]);
            }

        }
    }
}
