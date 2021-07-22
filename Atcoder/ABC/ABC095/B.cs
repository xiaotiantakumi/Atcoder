using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC095
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var f = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = f[0];
            var X = f[1];
            int minMaterial = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                var material = int.Parse(Console.ReadLine());
                X -= material;
                if (minMaterial >= material)
                {
                    minMaterial = material;
                }
            }

            var countMinMaterial = X / minMaterial;
            Console.WriteLine(N + countMinMaterial);
        }
    }
}