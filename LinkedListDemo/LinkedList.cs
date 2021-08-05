﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else 
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(" Element {0} inserted into the LinkedList. ", node.data);
        }
    }
}
