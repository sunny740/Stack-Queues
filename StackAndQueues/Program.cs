using System;
namespace StackAndQueues
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" **** Welcome to Linked List Program **** ");
            //StackAndQueues stack = new StackAndQueues();
            Console.WriteLine(" Display Stack Elements 1\n Peek And Pop Operation 2\n Deleting Top of the Elements Of Stack 3\n Checking Stack is Empty 4\n Display Queue Elements 5\n");
            bool end = true;
            Console.WriteLine("\n1.StackPush\n2.StackPickPop\n3.Enqueue\n4.End Of Program ");
            while (end)
            {
                StackAndQueues stack = new StackAndQueues();
                StackAndQueues2 queue = new StackAndQueues2();
                Console.WriteLine("\nEnter Option For Exicute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    case 2:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.IsEmpty();
                        break;
                    case 3:
                        queue.Enqueues(70);
                        queue.Enqueues(30);
                        queue.Enqueues(56);
                        queue.Display();
                        break;
                    case 4:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option");
                        break;

                }
            }
        }
    }
}