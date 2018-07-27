using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStrcutures
{
    class Queue : ICommonFunction
    {
        int[] elements=new int[50];
        int front;
        int rear;
        public Queue()
        {
            front = -1;
            rear = -1;
        }
        public void Add(int data)
        {
            if (rear == -1)
            {
                front = 0;
                rear = 0;
                elements[rear] = data;
            }
            else if (rear + 1 >= 50)
            {
                Console.WriteLine("Queue is already full.No more elements can be added");
            }
            else if (rear + 1 < 50)
            {
                rear = rear + 1;
                elements[rear] = data;
            }
        }
        public void Display()
        {
            for (int index = front; index <= rear; index++)
            {
                Console.Write(elements[index] + " ");
            }
            if (front == -1)
            {
                Console.WriteLine("Queue is Empty.");
            }
            Console.WriteLine();
        }
        public void Sort()
        {
            int temp;
            for (int rowIndex = front; rowIndex <= rear; rowIndex++)
            {
                for (int colIndex = front; colIndex <= rear - rowIndex - 1; colIndex++)
                {
                    if (elements[colIndex] > elements[colIndex + 1])
                    {
                        temp = elements[colIndex];
                        elements[colIndex] = elements[colIndex + 1];
                        elements[colIndex + 1] = temp;
                    }
                }
            }
        }
        public int Remove()
        {
            int result = 0;
            if (rear == -1)
            {
                Console.WriteLine("Queue is Empty.No more deletions can be done");
            }
            else
            {
                result = elements[front];
                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = front + 1; ;
                }
            }
            return result;
        }
        public int Peek()
        {
            int result = -1;
            if (front == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
                result = elements[front];
            return result;
        }
        public bool IsFull()
        {
            if (front == 0 && rear + 1 >= 50)
                return true;
            else
                return false;
        }
        public bool IsEmpty()
        {
            if (front == -1)
                return true;
            else
                return false;
        }
    }

}
