using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class Node
    {
        public int Value { get; set; }

        public Node ParentNode { get; set; }

        public Node LeftNode { get; set; }

        public Node RightNode { get; set; }

        public Node(Node parentNode, int value)
        {
            ParentNode = parentNode;
            Value = value;
        }
        public void Add(int value)
        {
            //Should go left
            if (value < Value)
            {
                if (LeftNode == null) LeftNode = new Node(this, value);
                else LeftNode.Add(value);

            }else if(value >= Value)
            {
                //Value is greater or equal add right node
                if (RightNode == null) RightNode = new Node(this, value);
                else RightNode.Add(value);
            }
        }
        public void NumberOfOccurence(ref int count, int searchedValue, Node node)
        {
            if (node.Value == searchedValue) count++;
            if (node.RightNode != null) NumberOfOccurence(ref count, searchedValue, node.RightNode);
            if (node.LeftNode != null) NumberOfOccurence(ref count, searchedValue, node.LeftNode);
        }
    }
}
