using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackProject;
using QueueProject;
using MockDataGenerator;

namespace DAS_Assignment
{
    /// <summary>
    /// School task assigment to create custom stack {later i hope even queue}
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Queue();
            //GenerateMockData();
        }
        static void GenerateMockData()
        {
            var mockGenerator = new MockNumberGenerator();

            var mockSpecification = new MockDataSpecification()
            {
                ValueFrom = 0,
                ValueTo = 10,
                Count = 500
            };

            mockGenerator.WriteRandomNumbersInFile(mockSpecification);
        }
        static void Queue()
        {
            Console.WriteLine("Insert queue size.");

            string userSetUp = Console.ReadLine();

            int queueSize;
            var parseResult = Int32.TryParse(userSetUp, out queueSize);

            if (!parseResult)
                Console.WriteLine("Error, size is not a number.");

            var queue = new QueueProject.Queue(queueSize);

            var endProgram = false;

            while (!endProgram)
            {
                Console.WriteLine("Press  a  to push to queue.");
                Console.WriteLine("Press  b  to pop from queue.");
                Console.WriteLine("Press  c  to end program");

                var pressedKey = Console.ReadLine();

                if (pressedKey == "c")
                {
                    endProgram = true;
                    continue;
                }
                else if (pressedKey == "a")
                {
                    if (queue.IsFull())
                    {
                        Console.WriteLine("Queue is full.");
                    }
                    else
                    {
                        Console.WriteLine("Insert number to push to queue.");
                        var number = Console.ReadLine();
                        queue.Push(number);
                    }

                }
                else if (pressedKey == "b")
                {
                    if (queue.IsEmpty())
                    {
                        Console.WriteLine("Queue is empty.");
                    }
                    else
                    {
                        var popedItem = queue.Pop();
                        Console.WriteLine();
                        Console.WriteLine("Poped item: " + popedItem);
                    }

                }
                Console.WriteLine();
                Console.WriteLine(queue.ToString());
                Console.WriteLine();
            }
        }
        static void Stack()
        {

            Console.WriteLine("Insert stack size.");

            string userSetUp = Console.ReadLine();

            int stackSize;
            var parseResult = Int32.TryParse(userSetUp, out stackSize);

            if (!parseResult)
                Console.WriteLine("Error, size is not a number.");

            var stack = new Stack(stackSize);
            var endProgram = false;

            while (!endProgram)
            {
                Console.WriteLine("Press  a  to push to stack.");
                Console.WriteLine("Press  b  to pop from stack.");
                Console.WriteLine("Press  c  to end program");

                var pressedKey = Console.ReadLine();

                if (pressedKey == "c")
                {
                    endProgram = true;
                    continue;
                }
                else if (pressedKey == "a")
                {
                    if (stack.IsFull())
                    {
                        Console.WriteLine("Stack is full.");
                    }
                    else
                    {
                        Console.WriteLine("Insert number to push to stack.");
                        var number = Int32.Parse(Console.ReadLine());
                        stack.Push(number);
                    }

                }
                else if (pressedKey == "b")
                {
                    if (stack.IsEmpty())
                    {
                        Console.WriteLine("Stack is empty.");
                    }
                    else
                    {
                        var popedItem = stack.Pop();
                        Console.WriteLine();
                        Console.WriteLine("Poped item: " + popedItem);
                    }

                }
                Console.WriteLine();
                Console.WriteLine(stack.ToString());
                Console.WriteLine();

            }
        }
    }
}
