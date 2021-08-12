using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using CoderCommon;
using Microsoft.VisualBasic.CompilerServices;
using Console = System.Console;

namespace Atcoder
{
    partial class Program
    {
        private const long COMDIV = 1000000007;

        static void Main()
        {
            SourceExpander.Expander.Expand(ignoreAnyError: false);
            var N = int.Parse(Console.ReadLine());
            List<long[]> treeInfo = new List<long[]>();
            for (int i = 0; i < N - 1; i++)
            {
                var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
                treeInfo.Add(AB);
            }

            var dicNode = GraphUtil.CreateTree(treeInfo);
            List<long> history = new List<long>();
            dicNode[1].IsArrive = true;
            Execute(dicNode[1], history);
            Console.WriteLine(string.Join(" ",history));
        }

        private static void Execute(Node<long> currentNode,List<long> history)
        {
            history.Add(currentNode.Value);
            if (currentNode.Children != null)
            {
                var items = currentNode.Children.OrderBy(x => x.Value).ToList();
                for (int i = 0; i < items.Count; i++)
                {
                    var next = items[i];
                    if (next.IsArrive) continue;
                    next.IsArrive = true;
                    Execute(next, history);
                    history.Add(currentNode.Value);
                }
            }
        }
    }
}