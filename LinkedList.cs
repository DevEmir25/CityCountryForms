using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCountryDemo
{
    public class StackUsingLinkedlist
    {
        private class Node
        {
            public string data;
            public Node link;
        }
        Node top;
        
        public StackUsingLinkedlist()
        {
            this.top = null;
        }
        
        public string push(string x)
        {
            Node temp = new Node();
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
            }
            temp.data = x;
            temp.link = top;
            top = temp;
            return x;
        }

        public bool isEmpty()
        {
            return top == null;
        }
        
        public void pop() 
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            top = (top).link;
        }

        public void display()
        {
           
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.link;
                }
            }
        }
    }
}
