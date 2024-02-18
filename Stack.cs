using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace GAStackSinglyLinkedList_EdnalynnLaxa
{
     class Stack<T>
    {
        // Nested class StackNode representing elements in the stack.
        class StackNode<T>
        {
            // Define a generic class called Stack.
            // The 'T' here is a type parameter that allows this class to work with various data types.
            public T Value { get; set; }                    // Data stored in the node.
            public StackNode<T> Next { get; set; }          // Reference to the next node.

            public StackNode(T value)
            {
                Value = value;
                Next = null;
            }
            //A stack node in a singly linked list has a reference to the next node,
            //allowing you to move forward through the stack.
        }

        private StackNode<T> top;
        private int count;

        //A stack node is an essential component of a stack, particularly when implemented
        //using a linked list. It contains:

        //Data element storage.
        //A pointer or reference to the next node.
        //Support for stack operations like push and pop.
        public int Count
        {
            get { return count; }
        }

        public Stack()
        {
            top = null;
            count = 0;
        }
        //Explanation with comments:
        //private StackNode<T> top;: This private field holds a reference to the top node in the stack.
        //private int count;: This private field keeps track of the number of elements in the stack.
        //public int Count: This public property allows external code to access the count of elements in the stack.
        //public Stack(): This is the constructor of the Stack class. It initializes an empty stack.
        //Explanation for top:
        //The top reference is crucial in a stack, as it points to the most recently added element.
        //This allows for efficient push and pop operations,
        //as they only involve handling the top element without needing to traverse the entire structure.
        public void Push(T value)
        {
            StackNode<T> newNode = new StackNode<T>(value);
            //This line creates a new node for the stack ; StackNode<T> is the type of the node , showing what belongs
            //to the class and can hold data of any type "T". 
            newNode.Next = top;
            //.Next is a generated action to the top of the stack
            top = newNode;
            //the top action is implimented assigning to newNode to the top. 
            count++;
            //Adding to the stack 
        }
        //Explanation:
        //Creates a new node with the given value.
        //Sets its next reference to the current top.
        //Updates the top to be the new node.
        //Increments the count.


        public T Pop()
        {
            if (top == null)// using a bool condition to check if the stack is empty
                throw new InvalidOperationException("Stack is empty."); 
            //if the stack is empty , the message "Stack is empty" will queue 

            T value = top.Value;
            //if the stack has elemnents to it, this code is prompts 
            //places the value to the top. 
            top = top.Next;
            //This code updates the top part to the next detail in stack, 
            //In transition removing the current top element to the stack 
            count--;
            //Decrement count , keep track of numbers in collection
            return value;
            //Returns the value that was initially stored to the top

        }
        //Explanation:
        //Checks if the stack is empty.
        //Retrieves the value of the top element.
        //Updates the top to the next node.
        //Decreases the count and returns the value.

        public T Peek()
        {
            if (top == null) // if the top stack is empty run this code 
                throw new InvalidOperationException("Stack is empty."); // msg will prompt 

            return top.Value;
        }
        //Explanation:
        //Checks if the stack is empty.
        //Returns the value of the top element without removing it.

        public void Clear()
        {
            top = null; // top = empty , by setting it to null, removing any indication of any
                        // existing element transitioning the stack empty

            count = 0; //sets the count to 0 
        }
        //Resets the top to null.
        //Resets the count to zero.

    }
}

