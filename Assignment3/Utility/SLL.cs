﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment3.Utility
{
    public class SLL : ILinkedListADT
    {
        private Node head;
        private int count;

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public void AddLast(User value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void Add(User value, int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (index == 0)
            {
                AddFirst(value);
            }
            else if (index == count)
            {
                AddLast(value);
            }
            else
            {
                Node newNode = new Node(value);
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                count++;
            }
        }

        public void Replace(User value, int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = value;
        }

        public int Count()
        {
            return count;
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
                count--;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }
            else if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            count--;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (index == 0)
            {
                RemoveFirst();
            }
            else if (index == count - 1)
            {
                RemoveLast();
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                count--;
            }
        }

        public User GetValue(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int IndexOf(User value)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(User value)
        {
            return IndexOf(value) != -1;
        }
    }
}

