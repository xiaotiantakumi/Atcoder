using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC101
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = firstLine[0];
            var K = firstLine[1];
            var secoundLine = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            int ret = 0;

            for (int i = 0; i < secoundLine.Length;)
            {
                if (i == 0)
                {
                    i += K;
                }
                else
                {
                    i += K - 1;
                }
                ret++;
            }
            Console.WriteLine(ret);
        }
    }
}