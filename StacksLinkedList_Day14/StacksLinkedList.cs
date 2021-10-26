using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksLinkedList_Day14
{
    public class StacksLinkedList
    {
        internal Node top;                              //instead of head we use top and bottom in stacks and queues

        internal void Push(int data)                   //creating the psuh method which is similar to add first method in linkedlist
        {

            Node node = new Node(data);                 //creating a node object of the Node class 
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;

            }
            this.top = node;
            Console.WriteLine("{0} pushed into the stack ", node.data);
        }

        internal void Display()          //the display method is similar to the display method of linkeddlist
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
