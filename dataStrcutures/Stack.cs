using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStrcutures
{
    class Stack : ICommonFunction
    {
        int[] elements = new int[50];
        int top;
        public Stack()
        {
            top = -1;
        }
        public void Add(int value)
        {
            if (top >= 50)
            {
                Console.WriteLine("Stack is full. No more insertions can be done");
            }
            else
            {
                top = top + 1;
                elements[top] = value;
            }
        }

        public void Display()
        { 
           for (int index = top; index >= 0; index--)
           {
                Console.WriteLine(elements[index]);
            }
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.No elements are present");
            }
        }
        public void Sort()
        {
            int temp;
            for (int rowIndex = 0; rowIndex <= top; rowIndex++)
            {
                for (int colIndex = 0; colIndex <= top - rowIndex - 1; colIndex++)
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
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.No elements can be deleted");
            }
            else
            {
                result = elements[top];
                top = top - 1;
            }
            return result;
        }
        public int DisplayTop()
        {
            int tempTop = -1;
            if (top <= -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                tempTop = elements[top];
            }
            return tempTop;
        }
    }

}


