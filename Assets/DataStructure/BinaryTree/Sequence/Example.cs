using BinaryTree;
using UnityEngine;
namespace BinaryTree.Sequence
{
    public class Example : MonoBehaviour
    {
        void Start()
        {
            char[] array = { 'A', 'B', 'C', 'D', 'E', 'F' };
            BiTree<char> tree = new BiTree<char>();
            foreach (var item in array)
            {
                tree.Add(item);
            }
            //tree.PreorderTraversal();
            //tree.InorderTraversal();
            tree.PostorderTraversal();
        }
    }
}
