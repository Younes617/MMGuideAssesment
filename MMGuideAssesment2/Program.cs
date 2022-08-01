using System;
using System.Collections.Generic;
using System.Linq;

namespace MMGuideAssesment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lList = new LinkedList<int>();
            lList.AddFirst(1);
            lList.AddLast(2);
            lList.AddLast(3);
            lList.AddLast(4);
            lList.AddLast(5);

            var loop = reverseLoopLinkedList(lList);
            var recursion = reverseRecursionLinkedList(lList);

            foreach (int i in loop)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------");
            foreach (int i in recursion)
            {
                Console.WriteLine(i);
            }
        }

        static public LinkedList<int> reverseLoopLinkedList(LinkedList<int> input)
        {
            var output = new LinkedList<int>();
            foreach (int i in input)
            {
                output.AddFirst(i);
            }
            return output;
        }

        static public LinkedList<int> reverseRecursionLinkedList(LinkedList<int> input)
        {
            if (input.First.Next == null)
            {
                return input;
            }

            var temp = input.First;
            input.RemoveFirst();
            reverseRecursionLinkedList(input);
            input.AddLast(temp);

            return input;
        }
    }
}
