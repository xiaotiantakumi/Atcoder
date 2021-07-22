using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC130
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = first[0];
            var X = first[1];
            var Ls = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = 1;
            int D = 0;

            for (int i = 0; i < N; i++)
            {
                D = D + Ls[i];
                if (D <= X)
                {
                    result++;
                }
            }
            Console.Write(result);
        }
    }
}