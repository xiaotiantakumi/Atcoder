using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.典型90
{
    public class NO4 : CoderBase
    {
        public override  void Run()
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = HW[0];
            var W = HW[1];
            var inp = Array.ConvertAll(new bool[H], _ => Console.ReadLine().Split().Select(int.Parse).ToArray());

            var rows = new int[H];
            var cols = new int[W];

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    rows[i] += inp[i][j];
                    cols[j] += inp[i][j];
                }
            }
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    inp[i][j] = rows[i] + cols[j] - inp[i][j];
                }
            }

            for (int i = 0; i < H; i++)
            {
                Console.WriteLine(string.Join(" ", inp[i]));
            }
        }
    }
}