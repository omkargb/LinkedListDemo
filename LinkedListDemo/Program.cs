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
            list.Add(56);
            list.Add(30);
            list.Add(70);

            Console.WriteLine("\n Remove last element --> ");
            list.RemoveLastNode();
            list.Display();

            //add in reverse order
            //list.AddInReverseOrder(70);
            //list.AddInReverseOrder(30);
            //list.AddInReverseOrder(56);
            //list.InsertAtParticularPosition(1, 30);
            //list.Append(40);
            //list.RemoveFirstNode();
        }
    }
}
