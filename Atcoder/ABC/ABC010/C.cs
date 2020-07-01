using System;
using System.Linq;

namespace Atcoder.ABC.ABC010
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var fx = r[0];
            var fy = r[1];
            var tx = r[2];
            var ty = r[3];
            var T = r[4];
            var V = r[5];
            var canMove = T * V;
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                var r2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var dx = r2[0];
                var dy = r2[1];
                var distance1 = Math.Sqrt(Math.Pow(dx - fx, 2) + Math.Pow(dy - fy, 2));
                var distance2 = Math.Sqrt(Math.Pow(dx - tx, 2) + Math.Pow(dy - ty, 2));
                var distance = distance1 + distance2;
                if (distance <= canMove)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            Console.WriteLine("NO");
        }
    }
}