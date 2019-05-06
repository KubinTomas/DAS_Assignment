using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackProject;
using QueueProject;
using MockDataGenerator;
using DataManipulator;
using BubbleSortPr;
using InsertSortPr;
using QuickSort;
using DataReader;
using System.Diagnostics;
using BST;

namespace DAS_Assignment
{
    /// <summary>
    /// School task assigment to create custom stack {later i hope even queue}
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //var bsTree = new BSTree(new[] { 12, 8, 3, 15, 12, 7, 2, 19, 11, 3 });

            //var a = bsTree.NumberOfOccurence(12);
            //var b = bsTree.NumberOfOccurence(0);
            //var c = bsTree.NumberOfOccurence(8);
            //var d = bsTree.NumberOfOccurence(3);

            ////bsTree.Delete(bsTree.Root, 12);
            ////bsTree.Delete(bsTree.Root, 12);
            ////bsTree.Delete(bsTree.Root, 2);
            ////bsTree.Delete(bsTree.Root, 0);
            //bsTree.Delete(bsTree.Root, 19);

            Console.WriteLine();


            GenerateMockData();

            var reader = new Reader();
            var writer = new Writer();

            //var quickSort = new DualPivotQuickSort();

            Console.WriteLine("Zadejte kolik cisel se ma generovat");
            var range = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Rozsah od");
            var from = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Rozsah do");
            var to = Int32.Parse(Console.ReadLine());

            var mockGenerator = new MockNumberGenerator();

            var mockSpecification = new MockDataSpecification()
            {
                ValueFrom = from,
                ValueTo = to,
                Count = range
            };

            mockGenerator.WriteRandomNumbersInFile(mockSpecification);

            var data = reader.Read();

            Console.WriteLine("Tvorim strom");

            var bsTree = new BSTree(data);

            Console.WriteLine("Strom vytvoren");

            var runUntil = true;

            while (runUntil)
            {

                Console.WriteLine("Press  a to add value.");
                Console.WriteLine("Press  b  search value");
                Console.WriteLine("Press  c  remove value");
                Console.WriteLine("Press  d  to end");

                var pressedKey = Console.ReadLine();

                if (pressedKey == "a")
                {
                    Console.WriteLine("Zadejte cislo k pridani");
                    var number = Int32.Parse(Console.ReadLine());

                    bsTree.Add(number);
                    Console.WriteLine("Cislo pridano: " + number);
                }
                else if (pressedKey == "b")
                {
                    Console.WriteLine("Zadejte cislo k vypoctu vyskytu");
                    var number = Int32.Parse(Console.ReadLine());

                    var value = bsTree.NumberOfOccurence(number);

                    Console.WriteLine("Pocet vyskytu: " + value);
                }
                else if (pressedKey == "c")
                {
                    Console.WriteLine("Zadejte cislo k odstraneni ze stromu");
                    var number = Int32.Parse(Console.ReadLine());

                    bsTree.Delete(bsTree.Root, number);

                    Console.WriteLine("Odstraneni dokonceno");
                }

                else if (pressedKey == "d")
                {
                    runUntil = false;
                }
            }

            //Console.WriteLine("Konec, diiiky");

            //Console.WriteLine("Data se sortuji");

            //var sortedData = quickSort.Sort(data);

            //Console.WriteLine("Data se zapisuji");

            //writer.WriteDataInFile(data, "quicksortOutput.txt");

            //Console.WriteLine("Operace dokoncena");

            //var binarySerach = new BinarySearchDll.BinarySearch();

            //Console.WriteLine("Zadejte hledane cislo");
            //var searchedNumber = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Hledam pocetnost cisla: " + searchedNumber);

            //var count = binarySerach.GetNumberCountInNumbers(searchedNumber, sortedData);

            //Console.WriteLine("Operace dokoncena");
            //Console.WriteLine("Cislo: " + searchedNumber + " se vyskytuje: " + count);

            //var runUntil = true;

            //while (runUntil)
            //{

            //    Console.WriteLine("Press  a  to continue.");
            //    Console.WriteLine("Press  b  end");

            //    var pressedKey = Console.ReadLine();

            //    if (pressedKey == "a")
            //    {
            //        Console.WriteLine("Zadejte hledane cislo");
            //        searchedNumber = Int32.Parse(Console.ReadLine());
            //        Console.WriteLine("Hledam pocetnost cisla: " + searchedNumber);
            //        count = binarySerach.GetNumberCountInNumbers(searchedNumber, sortedData);
            //        Console.WriteLine("Operace dokoncena");
            //        Console.WriteLine("Cislo: " + searchedNumber + " se vyskytuje: " + count);
            //    }
            //    else if (pressedKey == "b")
            //    {
            //        runUntil = false;
            //    }
            //}

            //Console.WriteLine("Konec, diiiky");

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
        static void BubbleVsInsertionSort()
        {
            GenerateMockData();

            var reader = new Reader();
            var writer = new Writer();

            var insertionSort = new InsertionSort();
            var bubbleSort = new BubbleSort();

            var endProgram = false;

            while (!endProgram)
            {
                Console.WriteLine("Press  a  generate mock data.");
                Console.WriteLine("Press  b  to bubble sort");
                Console.WriteLine("Press  c  to insertion sort");
                Console.WriteLine("Press  d  to end program");

                var pressedKey = Console.ReadLine();

                if (pressedKey == "a")
                {
                    GenerateMockData();

                    Console.WriteLine("Operation finished");

                    continue;
                }
                if (pressedKey == "b")
                {
                    var data = reader.Read();

                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();

                    data = bubbleSort.Sort(data);
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed: " + stopWatch.Elapsed);

                    Console.WriteLine("Sorting done, swap number: " + bubbleSort.SwapCounter);

                    Console.WriteLine("Writting data");

                    writer.WriteDataInFile(data, "bubbleOutput.txt");

                    Console.WriteLine("Operation finished");


                    continue;
                }
                if (pressedKey == "c")
                {
                    var data = reader.Read();


                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();

                    data = insertionSort.Sort(data);

                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed: " + stopWatch.Elapsed);

                    Console.WriteLine("Sorting done, swap number: " + insertionSort.SwapCounter);

                    Console.WriteLine("Writting data");

                    writer.WriteDataInFile(data, "insertionOutput.txt");

                    Console.WriteLine("Operation finished");


                    continue;
                }
                if (pressedKey == "d")
                {
                    endProgram = true;

                    continue;
                }


                Console.WriteLine();
                Console.WriteLine();
            }
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
