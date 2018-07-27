using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStrcutures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice. \n Press 1 for stack. \n Press 2 for Queue \n Press 3 for Linked List \n Press 4 to Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            
                switch (choice)
                {
                    case 1:
                        Stack stackObject = new Stack();
                        int flag = 1;
                        while (flag != 0)
                        {
                            Console.WriteLine("Enter your choice for the following stack operations");
                            Console.WriteLine(" 1. for Add \n 2. Display \n 3. for Remove \n 4. for Top value \n 5. for Sort \n ");
                            int operation = Convert.ToInt32(Console.ReadLine());
                            switch (operation)
                            {
                                case 1:
                                    Console.WriteLine("Enter Element i.e. to be Added in the stack");
                                    int data = int.Parse(Console.ReadLine());
                                    stackObject.Add(data);
                                    break;
                                case 2:
                                    stackObject.Display();
                                    break;
                                case 3:
                                    int removedElement = stackObject.Remove();
                                    Console.WriteLine(removedElement + " Removed from the top of the stack");
                                    break;
                                case 4:
                                    int topElement = stackObject.DisplayTop();
                                    Console.WriteLine(topElement + " is present at the top of Stack");
                                    break;
                                case 5:
                                    Console.WriteLine("Unsorted stack:- \n ");
                                    stackObject.Display();
                                    stackObject.Sort();
                                    Console.WriteLine("Sorted stack:- \n ");
                                    stackObject.Display();
                                    Console.WriteLine("Sorting has been done successfully");
                                    break;
                                default:
                                    Console.WriteLine("Invalid Operation. Please Enter the correct choice");
                                    break;
                            }
                            Console.WriteLine("Enter 1 to Continue and 0 To Stop :- ");
                            flag = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        }
                        break;
                    case 2:
                        Queue queueObject = new Queue();
                        int loop = 1;
                        while (loop == 1)
                        {
                            Console.WriteLine("Enter your choice for the following queue operations.");
                            Console.WriteLine(" 1. for Add \n 2. for Display \n 3. for Remove \n 4. for Peek \n 5. for Sort \n 6. checking Empty queue \n 7. for full queue \n ");
                            int operation = int.Parse(Console.ReadLine());
                            switch (operation)
                            {
                                case 1:
                                    Console.WriteLine("Enter Element i.e. to be Added in the queue");
                                    int data = int.Parse(Console.ReadLine());
                                    queueObject.Add(data);
                                    break;
                                case 2:
                                    queueObject.Display();
                                    break;
                                case 3:
                                    int removedElement = queueObject.Remove();
                                    Console.WriteLine(removedElement + " Removed from the front of the queue");
                                    break;
                                case 4:
                                    int topElement = queueObject.Peek();
                                    Console.WriteLine(topElement + " is present at the front of the queue");
                                    break;
                                case 5:
                                    Console.WriteLine("unsorted Queue \n");
                                    queueObject.Display();
                                    queueObject.Sort();
                                    Console.WriteLine("Sorted Queue \n");
                                    queueObject.Display();
                                    Console.WriteLine("Sorting has been done successfully");
                                    break;
                                case 6:
                                    if (queueObject.IsEmpty())
                                        Console.WriteLine("Queue is empty.");
                                    else
                                        Console.WriteLine("Queue is not empty.");
                                    break;
                                case 7:
                                    if (queueObject.IsFull())
                                        Console.WriteLine("Queue is full.");
                                    else
                                        Console.WriteLine("Queue is not full.");
                                    break;
                                default:
                                    Console.WriteLine("Invalid Operation. Please Enter the correct choice");
                                    break;
                            }
                            Console.WriteLine("Enter 1 to Continue and 0 To Stop :- ");
                            loop = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                    }
                        break;
                    case 3:
                        LinkedList linkedListObject = new LinkedList();
                        int flag1 = 1;
                        while (flag1 == 1)
                        {
                            Console.WriteLine("Enter your choice for the following linkedlist operations.");
                            Console.WriteLine(" 1. for Add At Beginning \n 2. for Add At End \n 3. for Remove at Beginning \n 4. for Display \n 5. for Sort \n 6. for Insertion At Specific Location \n 7. for Deletion At Specific Location \n 8. For removing At Last");
                            int operation = Convert.ToInt32(Console.ReadLine());
                            switch (operation)
                            { 
                                case 1:
                                    Console.WriteLine("Enter Element i.e. to be Added in the LinkedList At Beginning");
                                    int data = int.Parse(Console.ReadLine());
                                    linkedListObject.Add(data);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Element i.e. to be Added in the LinkedList At End");
                                    data = int.Parse(Console.ReadLine());
                                    linkedListObject.AddAtEnd(data);
                                    break;
                                case 3:
                                    int removedElement = linkedListObject.Remove();
                                    Console.WriteLine(removedElement + " Removed from the front of the linkedList");
                                    break;
                                case 4:
                                    linkedListObject.Display();
                                    break;
                                case 5:
                                    Console.WriteLine("unsorted LinkedList \n");
                                    linkedListObject.Display();
                                    linkedListObject.Sort();
                                    Console.WriteLine("Sorted LinkedList \n");
                                    linkedListObject.Display();
                                    Console.WriteLine("Sorting has been done successfully");
                                    break;
                                case 6:
                                    Console.WriteLine("Enter Element i.e. to be Added in the LinkedList");
                                    data = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter position where element.is to be Added in the LinkedList");
                                    int position = int.Parse(Console.ReadLine());
                                    linkedListObject.AddAtIndex(position, data);
                                    linkedListObject.Display();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter position from where element.is to be removed in the LinkedList");
                                    position = int.Parse(Console.ReadLine());
                                    removedElement = linkedListObject.RemoveAtIndex(position);
                                    Console.WriteLine(removedElement + " Removed from the linkedList");
                                    break;
                                case 8:
                                    removedElement = linkedListObject.RemoveAtEnd();
                                    Console.WriteLine(removedElement + " Removed from the end of the linkedList");
                                    break;
                                default:
                                    Console.WriteLine("Invalid Operation. Please Enter the correct choice");
                                    break;

                            }
                            Console.WriteLine("Enter 1 to Continue and 0 To Stop :- ");
                            flag1 = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                    }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry. Please Enter the correct choice");
                        break;
                }
               
        }
    }
}
