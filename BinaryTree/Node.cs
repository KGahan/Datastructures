using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int _current)
        {
            data = _current;
            left = null;
            right = null;
        }
    }
}
