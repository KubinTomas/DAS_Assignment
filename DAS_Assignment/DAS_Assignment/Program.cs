using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackProject;

namespace DAS_Assignment
{
    /// <summary>
    /// School task assigment to create custom stack {later i hope even queue}
    /// </summary>
    class Program
    {
        static void Main(string[] args)
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
