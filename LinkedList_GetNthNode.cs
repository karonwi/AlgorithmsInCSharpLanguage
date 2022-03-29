using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class LinkedList_GetNthNode
    {
        #region Question
        /*Implement a GetNth() function that takes a linked list and an integer index and returns the node stored at the Nth index position.
            GetNth() uses the C numbering convention that the first node is index 0, the second is index 1, ... and so on.So for the list 42 -> 13 -> 666, GetNth() with index 1 should return Node(13);

        Node.GetNth(1 -> 2 -> 3 -> null, 0).Data == 1
        Node.GetNth(1 -> 2 -> 3 -> null, 1).Data == 2
        The index should be in the range[0..length - 1]. If it is not, GetNth() should throw/raise an exception(ArgumentException in C#, InvalidArgumentException in PHP). 
        You should also raise an exception (ArgumentException in C#, InvalidArgumentException in PHP) if the list is empty/null/None.
        */

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

            public static Node GetNth(Node node, int index)
            {
                //If index not in range throw exception
                if (node == null) { throw new ArgumentException(); }
                if (index == 0) return node;

                //If the list is empty,throw an exception
                //then find the nth term at a particular position
                Node temp = node;
                for (int i = 0; i <= index; i++)
                {

                    if (i == index)
                    {
                        return temp;
                    }
                    else if (temp.Next == null)
                    {
                        throw new ArgumentException();
                    }
                    temp = temp.Next;

                }
                throw new ArgumentException();

            }
        }
    }
}
