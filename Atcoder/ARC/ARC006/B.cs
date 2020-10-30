using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ARC.ARC006
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var NL = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = NL[0];
            var L = NL[1];
            List<string> graph = new List<string>();
            for (int i = 0; i <= L; i++)
            {
                graph.Add(Console.ReadLine());
            }

            int currentPos = 0;
            for (var i = graph.Count - 1; i >= 0; i--)
            {
                var line = graph[i];
                if (i == graph.Count - 1)
                {
                    currentPos = line.IndexOf('o');
                }
                else
                {
                    if (currentPos > 0 && line[currentPos - 1] == '-')
                    {
                        currentPos -= 2;
                    }
                    else if (currentPos < line.Length - 1 && line[currentPos + 1] == '-')
                    {
                        currentPos += 2;
                    }
                }
            }

            Console.WriteLine(currentPos / 2 + 1);
        }
    }
}