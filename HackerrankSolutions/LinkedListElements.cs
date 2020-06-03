using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutions
{
    public class LinkedListElements
    {
        static void Main(string[] args)
        {
            //SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                //int llistItem = Convert.ToInt32(Console.ReadLine());
                //llist.InsertNode(llistItem);
            }

            //printLinkedList(llist.head);
        }
    }

    class SinglyLinkedListNode
    {
        int data;
        SinglyLinkedListNode next;
    }
}
