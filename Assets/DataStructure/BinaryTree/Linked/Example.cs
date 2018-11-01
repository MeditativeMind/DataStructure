using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BinaryTree.Linked
{
    public class Example : MonoBehaviour
    {
        
        // Use this for initialization
        void Start()
        {
            char[] s = { 'A', 'B', 'C', 'D', 'E', 'F' };
            LinkedBinaryTree<char> tree = new LinkedBinaryTree<char>(s[0]);
            tree.InsertLeft(s[1],tree.Head);
            tree.InsertRight(s[2], tree.Head);
            tree.InsertRight(s[3], tree.Head.LeftChild);
            tree.InsertLeft(s[4], tree.Head.RightChild);
            tree.InsertLeft(s[5], tree.Head.LeftChild.RightChild);
           var v =  tree.LevelOrder();
            foreach (var item in v)
            {
                print(item.Data);
            }
        }
    }
}
