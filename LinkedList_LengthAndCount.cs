using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class LinkedList_LengthAndCount
    {
        #region Question
        /*Implement Length() to count the number of nodes in a linked list.
        Node.Length(nullptr) => 0
        Node.Length(1 -> 2 -> 3 -> nullptr) => 3
        Implement Count() to count the occurrences of a that satisfy a condition provided by a predicate which takes in a node's Data value.
        Node.Count(null, value => value == 1) => 0
        Node.Count(1 -> 3 -> 5 -> 6, value => value % 2 != 0) => 3
        I've decided to bundle these two functions within the same Kata since they are both very similar.
        The push()/Push() and buildOneTwoThree()/BuildOneTwoThree() functions do not need to be redefined.*/

        #endregion
        public partial class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }

            public static int Length(Node head)
            {
                Node item = head;
                int length = 0;
                while (item != null)
                {
                    length++;
                    item = item.Next;
                }
                return length;

            }

            public static int Count(Node head, Predicate<int> func)
            {
                Node item = head;
                int count = 0;
                while (item != null)
                {
                    if (func(item.Data))
                    {
                        count++;
                    }
                    item = item.Next;
                }
                return count;
            }
        }

    }
}
