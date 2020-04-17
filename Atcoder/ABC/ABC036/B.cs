using System;
using System.Collections.Generic;

namespace Atcoder.ABC036
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            List<string> graph = new List<string>();
            for (int i = 0; i < N; i++)
            {
                graph.Add(Console.ReadLine());
            }
            List<string> ret = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string row = string.Empty;
                for (int j = N - 1; j >= 0; j--)
                {
                    row += graph[j][i].ToString();
                }
                ret.Add(row);
            }

            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }
        }
    }
}