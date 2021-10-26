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
                Console.WriteLine("Stack is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void Peek()               //this method tells us about the first element of the stack.it just views.
        {
            if (this.top == null)
                Console.WriteLine("The stacks is empty!");
            Console.WriteLine("{0} is in the top of the stack.", this.top.data);

        }

        internal void Pop()               //deletes the first node of the stack
        {
            if (this.top == null)
                Console.WriteLine("Deletion is not posssible");

            Console.WriteLine("Deleted node from stack: " + this.top.data);  //prints the deleted node
            this.top = this.top.next;
        }

        internal void IsEmpty()          //this repreatedly calls the pop method that will delete the first element from the stack in each iteration
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
        }

        internal void Enqueue(int data)        //the append(enqueue) method it is similar to Add method or Add last
        {
            Node node = new Node(data);        //creating a node object of the Node class 
            if (this.top == null)
            {
                this.top = node;
            }
            else
            {
                Node temp = top;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} added into Queue", node.data);
        }



    }
}
