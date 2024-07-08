using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    class LinkListGen<T> where T : IComparable
    {
        //CompareTo is a built-in method of IComparable and in this case does not need to be overriden.

        private NodeGen<T> head;

        public LinkListGen()
        {
            head = null;
        }
        public void AddToHead(T item)
        {
            NodeGen<T> temp = new NodeGen<T>(item);
            if(head == null)
            {
                head = temp;
            }
            else
            {
                temp.Next = head;
                head = temp;
            }
        }
        public string DisplayList()
        {   
                NodeGen<T> temp = head;
                string buffer = "";
                while (temp != null) // move one node and add head to the buffer
                {
                    if (buffer.Length == 0)
                        buffer = buffer + temp.Data;
                    else
                        buffer = buffer + "->" + temp.Data;
                    temp = temp.Next;
                }
                return buffer;

        }
        public int NumberOfItems()
        {
            NodeGen<T> temp = head;
            int counter = 0;
            while (temp != null)
            {
                counter += 1;
                temp = temp.Next;
            }
            return counter;
            

        }
        public bool IsPresentItem(T item)
        {
            NodeGen<T> temp = head;
            while (temp != null)
            {
                if (temp.Data.CompareTo(item) == 0)
                {
                    return true;
                    
                }
                temp = temp.Next;
            }
            return false;
        }

        public void AppendItem(T item)
        {
            NodeGen<T> newNode = new NodeGen<T>(item);
            NodeGen<T> temp = head;
            if (head == null)//if empty, add to beginning
            {
                head = newNode;
                return;
            }
            while (temp.Next != null)//if not empty, seek the end of the list
            {
                temp = temp.Next;
            }
            temp.Next = newNode;//add to the end of the list
        }

        public void RemoveItem(T item)//remove all occurrences of item from the list
        {
            NodeGen<T> temp = head;
            LinkListGen<T> newList = new LinkListGen<T>();
            while (temp != null)
            {
                if(item.CompareTo(temp.Data) != 0)
                {
                    newList.AppendItem(temp.Data);
                }
                temp = temp.Next;
                
            }
            head = newList.head;
        }


        public void InsertInOrder(T item)
        {
            NodeGen<T> temp = head;
            LinkListGen<T> newList = new LinkListGen<T>();
            if (head == null)
            {
                AppendItem(item);
            }   
            else
            {
                while (temp != null)
                {
                    //int deb = item.CompareTo(temp.Data); //debug variable
                    if (item.CompareTo(temp.Data) <= 0)
                    {
                        //if the item is smaller or equal to the currently checked item in the list, append
                        //the break out of the loop is there in the event that the linked list is unsorted, to prevent duplication!
                        newList.AppendItem(item);
                        break;
                    }
                    else
                    {
                        //if item is bigger, add the data in the linkedlist to the new list.
                        newList.AppendItem(temp.Data);
                    }
                    temp = temp.Next;
                }
                if (temp == null)
                {
                    //in the event that the item was bigger than all the items currently within the linked list, append to the end
                    newList.AppendItem(item);
                }
                else
                {
                    //if the item was already added into the list, add the remaining items to the new list.
                    while (temp != null)
                    {
                        newList.AppendItem(temp.Data);
                        temp = temp.Next;
                    }
                }
                

                head = newList.head;
            }
        }

        public void Sort()
        {
            //creates a new tempoary list that simply inserts each item from the current list in order, making the list sorted by defualt!
            NodeGen<T> temp = head;
            LinkListGen<T> newList = new LinkListGen<T>();

            while(temp != null)
            {
                newList.InsertInOrder(temp.Data);
                temp = temp.Next;
            }
            head = newList.head;

        }
    }
}
