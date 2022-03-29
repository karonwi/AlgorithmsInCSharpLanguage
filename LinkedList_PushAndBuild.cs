using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class LinkedList_PushAndBuild
    {
        #region Question
        /* Write push() and buildOneTwoThree() functions to easily update and initialize linked lists.Try to use the push() function within your buildOneTwoThree() function.
         Here's an example of push() usage:
         Node chained = null;
         chained = Node.Push(chained, 3);
         chained = Node.Push(chained, 2);
         chained = Node.Push(chained, 1);
         Node.Push(chained, 8) => 8 -> 1 -> 2 -> 3 -> null
         The push function accepts head and data parameters, where head is either a node object or null/None/nil.Your push implementation should be able to create a new linked list/node when head is null/None/nil.
         The buildOneTwoThree function should create and return a linked list with three nodes: 1 -> 2 -> 3 -> null*/
        #endregion
        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }

            public static Node Push(Node head, int data)
            {
                Node s = new Node(data);
                s.Next = head;
                return s;
            }

            public static Node BuildOneTwoThree()
            {
                Node chained = null;
                chained = Node.Push(chained, 3);
                chained = Node.Push(chained, 2);
                chained = Node.Push(chained, 1);
                return chained;
            }
        }
    }
}
