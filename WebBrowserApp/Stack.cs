using System;
using System.Collections.Generic;
using System.Text;

namespace WebBrowserApp
{
    class Stack
    {
        static readonly int MAX = 20;
        int top;
        string[] stack = new string[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        public bool Push(string data)
        {
            if (top >= MAX)
            {
                Pop();
                stack[++top] = data;
            }
            else
            {
                stack[++top] = data;
                
            }
            return true;
        }

        public bool Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return false;
            }
            else
            {
                string value = stack[top--];
                return true;
            }
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
