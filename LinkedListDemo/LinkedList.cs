using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
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
            Console.WriteLine(" Element {0} added into the LinkedList. ", node.data);
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

        public Node InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            Console.WriteLine("\n Element {0} Inserted at position {1}.", data, position);
            Display();
            return this.head;
        }

        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            Console.WriteLine(" First node : {0} Removed.", this.head.data);
            this.head = this.head.next;
            return this.head;
        }

        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            Console.WriteLine("\n Last element [{0}] is removed", NewNode.next.data);
            NewNode.next = null;
            return head;
        }

        public Node Search(int searchValue)
        {
            int position=0;
            while (this.head != null)
            {
                if (this.head.data == searchValue)
                {
                    Console.WriteLine(" Element {0} found at position : {1}", searchValue, position);
                    return this.head;
                }
                position++;
            }
            return null;
        }


        public void RemoveElement(int element)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == element)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != element)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;

            prev.next = temp.next;
            Console.WriteLine(" Element : {0} is Removed..", element);
        }

        public int Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine(" LinkedList is empty...");
                return 0;
            }
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            Console.WriteLine(" Length of LinkedList is : " + " " + count);
            return count;
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
