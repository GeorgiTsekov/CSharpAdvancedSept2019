using System;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoubliLinkedList();

            doublyLinkedList.AddLast(1);
            doublyLinkedList.AddLast(2);
            doublyLinkedList.AddLast(3);

            doublyLinkedList.RemoveLast();
            
            doublyLinkedList.Print(Console.WriteLine);
            Console.WriteLine(doublyLinkedList.Count == 2);

            Console.WriteLine(doublyLinkedList.Contains(2));

            int[] array = doublyLinkedList.ToArray();
            
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
