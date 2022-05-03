using System;
namespace StackAndQueues
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" **** Welcome to Linked List Program **** ");
            bool end = true;
            Console.WriteLine("\n1.StackPush\n2.End Of Program ");
            while (end)
            {
                StackAndQueues stack = new StackAndQueues();
                Console.WriteLine("\nChoose An option");
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