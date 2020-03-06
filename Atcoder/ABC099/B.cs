using System;
using System.Linq;

namespace Atcoder.ABC099
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var dif = firstLine[1] - firstLine[0];
            int lastTree = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (lastTree == 0)
                {
                    lastTree = i;
                    continue;
                }

                var nowTree = lastTree + i;
                if (nowTree - lastTree == dif)
                {
                    Console.WriteLine(lastTree - firstLine[0]);
                    return;
                }

                lastTree = nowTree;
            }
        }
    }
}