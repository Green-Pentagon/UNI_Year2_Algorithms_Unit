using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    class LinkListInt
    {
        private Node head = null; //default value – empty list

        public void AddToHead(int item) //add item to front of list
        {
            Node newNode = new Node(item);
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.Next = head;
            head = newNode;

        }

        public string DisplayItems() //write items to string and return
        {
            Node temp = head;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                if (buffer.Length == 0)
                    buffer = buffer + temp.Data;
                else
                    buffer = buffer + "->" + temp.Data;
                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems() // returns number of items in list
        {
            Node temp = head;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
            }
            return count;
        }

        public bool IsPresentItem(int item)
        {
            Node temp = head;
            while (temp != null)
            {
                if(temp.Data == item)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
