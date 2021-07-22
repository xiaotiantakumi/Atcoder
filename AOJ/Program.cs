using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace AOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var inp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var parentId = inp[0];
                var k = inp[1];
                if (k == 0)
                {
                    
                }else if (k == 1)
                {
                    var parent = new Node();
                    parent.value = parentId;
                    parent.Left = new Node();
                    parent.Parent = null;

                    parent.Left.value = inp[i + k];
                    parent.Left.Parent = parent;
                    parent.Left.Left = null;
                }
                else
                {
                    
                }
                for (int j = 0; j < k; j++)
                {
                    
                }
            }
        }

        class Node
        {
            public int value;
            public Node Parent;
            public Node Left;
            public Node Right;
        }
    }
}
