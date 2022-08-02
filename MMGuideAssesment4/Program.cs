using System;
using System.Collections.Generic;

namespace MMGuideAssesment4
{
    class Program
    {
        public static List<int> foundNodes = new List<int>();
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(50);
            binaryTree.Add(17);
            binaryTree.Add(76);
            binaryTree.Add(9);
            binaryTree.Add(23);
            binaryTree.Add(54);
            binaryTree.Add(14);
            binaryTree.Add(19);
            binaryTree.Add(72);
            binaryTree.Add(12);
            binaryTree.Add(67);

            getLeafCount(binaryTree.Root);

            Console.WriteLine("Gevonden nodes:");
            if (foundNodes.Count == 0)
            {
                Console.WriteLine("GEEN");
            }
            else
            {
                foreach (int i in foundNodes)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        //  code gebaseerd op code van
        // https://www.geeksforgeeks.org/write-a-c-program-to-get-count-of-leaf-nodes-in-a-binary-tree/
        static public int getLeafCount(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.LeftNode == null && node.RightNode == null)
            {
                return 1;
            }
            else
            {
                if (getLeafCount(node.LeftNode) == 1) { foundNodes.Add(node.Data); }
                if (getLeafCount(node.RightNode) == 1) { foundNodes.Add(node.Data); }

                return 0;
            }
        }
    }
}
