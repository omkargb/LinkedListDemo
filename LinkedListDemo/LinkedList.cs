using System;
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


        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }

        internal void Append(int data)
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
                temp = temp.next;
                temp.next = node;
                Console.WriteLine(" Element {0} Appended to the {1} ", node.data, temp.data );
            }
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine(" This LinkedList is empty");
                return;
            }
            Console.Write("\n Displaying LinkedList : ");
            while (temp != null)
            {
                Console.Write(" → [" + temp.data + "]");
                temp = temp.next;
            }
            Console.WriteLine("\n");
        }

    }
}
