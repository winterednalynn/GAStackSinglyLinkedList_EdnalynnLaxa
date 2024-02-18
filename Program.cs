using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GAStackSinglyLinkedList_EdnalynnLaxa
{
    internal class Program
    {
        //EDNA LYNN LAXA 
        //FEBRUARY 17, 2024 
        //COMPUTER PROGRAMMING V 
        //ASSIGNMENT: STACKED WITH SINGLY LINKED LIST 
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            // Push elements
            stack.Push(10); // Adding int 10 
            stack.Push(20); //Adding int 20 
            stack.Push(30); // Adding int 30 




            //In total, three elements (10, 20, and 30) are added to the stack in a sequential manner by these lines.
            //The implementation of the Push method and the underlying data structure (such as an array or linked list)
            //used for the stack determine the precise behavior of how elements are added and stored.

            //In the majority of stack implementations:

            //New components are added to the stack's top.
            //New elements will be pushed on top of the old ones in subsequent pushes,
            //in accordance with the Last-In - First - Out(LIFO) concept.
            //Consequently, the components in the stack will probably be arranged as follows: 30 at the top,
            //20 at the middle, and 10 at the bottom once these lines execute.


            // Pop an element
            Console.WriteLine($"Popped: {stack.Pop()}");

            // Peek at the top element
            Console.WriteLine($"Top element: {stack.Peek()}");

            // Display count
            Console.WriteLine($"Count: {stack.Count}");

            Console.ReadLine();
        }
        // My gatherings: 
        //The following characteristics are combined in a data structure called a stack that is implemented using a singly linked list:
        //Stack:
        //The last-in-first-out (LIFO) principle states that items are added to and taken out at the top of the stack.
        //push(add element), Pop(remove and return top element), and Peek(return top element without removing it) are common operations.
        //Single-Link List://a linear data structure in which every component, or node, has a reference to the node after it and data.
        //A one-way chain links the nodes together.

    }
}
