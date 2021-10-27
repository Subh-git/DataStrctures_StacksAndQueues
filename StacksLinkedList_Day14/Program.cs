using System;

namespace StacksLinkedList_Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            StacksLinkedList stacks = new StacksLinkedList();
            stacks.Enqueue(56);                          
            stacks.Enqueue(30);
            stacks.Enqueue(70);
            stacks.Dequeue();          //dequeue meaning deletion from the first or top
            stacks.Display();
            
        }
    }
}
