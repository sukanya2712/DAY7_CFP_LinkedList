using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLIst
{
        class LinkedList
        {
            private LinkedListNode head;

            public void AddFirst(int data)
            {
                LinkedListNode newNode = new LinkedListNode(data);
                newNode.Next = head;
                head = newNode;
            }

            
            public void Display()
            {
                LinkedListNode current = head;

                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }

                Console.WriteLine();
            }
        }

 }

