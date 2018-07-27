using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStrcutures
{
    class Node
    {
        private int data;
        private Node next;

        public int Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        internal Node Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }
        public Node(int data)
        {
            this.Data = data;
        }

        public Node()
        {
            Next = null;
            Data = 0;
        }

    }
    class LinkedList : ICommonFunction
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }
        public void Add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = head;
            head = newNode;
        }
        public void AddAtEnd(int data)
        {
            if (head == null)
            {
                Add(data);
            }
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        public int Remove()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return 0;
            }
            else
            {
                Node current = head;
                head = head.Next;
                int x = current.Data;
                return x;
            }

        }
        public int RemoveAtEnd()
        {
            int x = 0;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                x = 0;
            }
            else if (head.Next == null)
            {
                Remove();
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                Node temp = current.Next;
                current.Next = null;
                x = temp.Data;

            }
            return x;

        }
        public void AddAtIndex(int index, int data)
        {
            Node temp = head;
            Node current = null;
            if (temp == null)
            {
                Add(data);
            }
            while (index > 1)
            {
                temp = temp.Next;
                index--;
            }
            if (temp != null)
            {
                current = temp.Next;
                temp.Next = new Node(data);
                temp.Next.Next = current;
            }
        }

        public int RemoveAtIndex(int index)
        {
            Node deletedNode = head;
            int result = -1;
            if (index < 1)
            {
                Console.WriteLine("Invalid Index");
                return -1;
            }
            if (index == 1)
            {
                result = head.Data;
                head = head.Next;
                return result;
            }
            while (index > 0)
            {
                if (deletedNode == null)
                    return -1;

                deletedNode = deletedNode.Next;
                index--;
            }
            result = deletedNode.Data;
            deletedNode.Data = deletedNode.Next.Data;
            deletedNode.Next = deletedNode.Next.Next;
            return result;
        }
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
        public void Sort()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            for (int index1 = 0; index1 < count; index1++)
            {
                int temp;
                Node tempNode = head;
                Node next = head.Next;
                for (int index2 = 0; index2 < count - 1; index2++)
                {
                    if (tempNode.Data > next.Data)
                    {
                        temp = tempNode.Data;
                        tempNode.Data = next.Data;
                        next.Data = temp;
                    }
                    tempNode = next;
                    next = next.Next;

                }
            }

        }
    }
}
