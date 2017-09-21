using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lighting_Talk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            ListDemo();
            HashSetDemo();
            QueueDemo();
            StackDemo();
            DictionaryDemo();
            Console.ReadKey();
        }

        static void ListDemo()
        {
            List<string> myList = new List<string> {
                "one",
                "two",
                "three" };
            PrintStatusForList(myList, "creating");
            myList.Add("four");
            PrintStatusForList(myList, "adding \"four\"");
            myList.Add("four");
            PrintStatusForList(myList, "adding \"four\" ONCE MORE");
            myList.RemoveAt(2);
            PrintStatusForList(myList, "removing element #3");
            //string iHaveFoundIt = myList.Find(x => x.StartsWith("o"));
            //PrintVariable("iHaveFoundIt", iHaveFoundIt);
        }

        static void QueueDemo()
        {
            List<string> myList = new List<string> {
                "one",
                "two",
                "three" };
            Queue<string> myQueue = new Queue<string>(myList);
            PrintStatusForQueue(myQueue, "creating");
            myQueue.Enqueue("four");
            PrintStatusForQueue(myQueue, "enqueuing \"four\"");
            myQueue.Enqueue("four");
            PrintStatusForQueue(myQueue, "enqueuing \"four\" ONCE MORE");
            string dequeuedElement = myQueue.Dequeue();
            PrintStatusForQueue(myQueue, "dequeuing last element");
            PrintVariable("dequeuedElement", dequeuedElement);
        }

        static void StackDemo()
        {
            List<string> myList = new List<string> {
                "one",
                "two",
                "three" };
            Stack<string> myStack = new Stack<string>(myList);
            PrintStatusForStack(myStack, "creating");
            myStack.Push("four");
            PrintStatusForStack(myStack, "pushing \"four\"");
            myStack.Push("four");
            PrintStatusForStack(myStack, "pushing \"four\" ONCE MORE");
            string poppedElement = myStack.Pop();
            PrintStatusForStack(myStack, "popping last element");
            PrintVariable("poppedElement", poppedElement);
        }

        static void DictionaryDemo()
        {
            Dictionary<string, string> englishMonarchs = new Dictionary<string, string>()
            {
                { "Elizabeth II", "Elizabeth Alexandra Mary" },
                { "George VI", "Albert Frederick Arthur George"},
                { "Edward VII", "Albert Edward" }
            };

            englishMonarchs.Add("Victoria", "I couldn't google her name");
            englishMonarchs["Victoria"] = "Alexandrina Victoria";
        }

        static void HashSetDemo()
        {
            List<string> myList = new List<string> {
                "one",
                "two",
                "three" };
            HashSet<string> myHashSet = new HashSet<string>(myList);
            PrintStatusForHashSet(myHashSet, "creating");
            myHashSet.Add("four");
            PrintStatusForHashSet(myHashSet, "adding \"four\"");
            myHashSet.Add("four");
            PrintStatusForHashSet(myHashSet, "adding \"four\" ONCE MORE");
            myHashSet.Remove("two");
            PrintStatusForHashSet(myHashSet, "removing \"two\" element");
        }

        private static void PrintVariable(string variableName, string variableValue)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($" Variable {variableName}: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(variableValue);
        }

        static void PrintStatusForList(List<string> myList, string eventText)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($" Number of elements after {eventText}: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(myList.Count);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" Elements after {eventText}:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            myList.ForEach(x => Console.Write($" {x}"));
            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStatusForQueue(Queue<string> myQueue, string eventText)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($" Number of elements after {eventText}: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(myQueue.Count);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" Elements after {eventText}:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var item in myQueue)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintStatusForStack(Stack<string> myStack, string eventText)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($" Number of elements after {eventText}: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(myStack.Count);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" Elements after {eventText}:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var item in myStack)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void PrintStatusForDictionary(Dictionary<string, string> myDictionary, string eventText)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($" Number of elements after {eventText}: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(myDictionary.Count);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" Elements after {eventText}:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var item in myDictionary)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(" Key:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($" {item.Key}");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(" Value:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($" {item.Value}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintStatusForHashSet(HashSet<string> myHashSet, string eventText)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($" Number of elements after {eventText}: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(myHashSet.Count);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" Elements after {eventText}:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var item in myHashSet)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
