using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class ReversedLinkedList
    {
        #region Question
        //  Implement a function reverse_list which takes a singly-linked list of nodes and returns a matching list in the reverse order.
        //Assume the presense of a class Node, which exposes the property value/Value and next/Next.next must either be set to the next Node in the list, or to None(or null) to indicate the end of the list.
        //To assist in writing tests, a function make_linked_list(Node.asLinkedList() in Java) has also been defined, which converts a python list to a linked list of Node.
        //The final tests will use a very long list. Be aware that a recursive solution will run out of stack.
        #endregion

        public class Kata
        {
            public static Node ReverseList(Node node)
            {
                // Node head = node;
                if (node == null || node.Next == null) return node;
                Node currentNode = node.Next;

                Node reversedList = node;
                reversedList.Next = null;
                while (currentNode != null)
                {
                    Node temp = currentNode;
                    currentNode = currentNode.Next;
                    temp.Next = reversedList;
                    reversedList = temp;
                }
                return reversedList;

            }
        }
    }
}
