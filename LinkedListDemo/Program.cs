using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to LinkedList program.\n");
            LinkedList list = new LinkedList();

            Console.WriteLine(" LinkedList Sequence : 56 -> 30 -> 70 \n");
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();

            //Console.WriteLine(" Node input Sequence : 70 -> 30 -> 56 \t Output LinkedList Sequence : 56 -> 30 -> 70");
            //add in reverse order
            //list.AddInReverseOrder(70);
            //list.AddInReverseOrder(30);
            //list.AddInReverseOrder(56);
            //list.Display();

        }
    }
}
